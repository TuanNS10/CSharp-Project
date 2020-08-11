
using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace CakeShop
{
    /// <summary>
    /// Interaction logic for NewProductPage.xaml
    /// </summary>
    public partial class NewProductPage : Page
    {
        /// <summary>
        /// Kết Nối CSDL
        /// </summary>
        CakeShop_SystemEntities db = new CakeShop_SystemEntities();

        //Cờ xác định vào để sửa hay thêm
        public bool isEdit = false;


        //Delegate để refresh danh sách sản phẩm
        public delegate void DelegateRefreshProductList(bool Data);
        public DelegateRefreshProductList RefreshProductList;
        public NewProductPage()
        {
            InitializeComponent();

            //get và hiển thị danh sách loại sản phẩm
            Thread getTypes = new Thread(delegate ()
            {
                var productTypes = new ObservableCollection<string>(db.ProductTypes.Select(x => x.Name));
                Dispatcher.Invoke(() =>
                {
                    comboProductTypes.ItemsSource = productTypes;// tác đông lên UI
                });
            });
            getTypes.Start();
        }
        public NewProductPage(Product product)
        {
            InitializeComponent();
            isEdit = true;
            //imgProduct.Tag = product.ImagePath;

            //Đưa thông tin lên UI
            Title.Content = "SỪA SẢN PHẨM";
            editProductName.Text = product.Name;
            editProductId.Text = product.Id;
            editProductId.IsEnabled = false;
            editProductPrice.Text = product.Price.ToString("N0");

            if (product.Description != null) editProductDescription.Text = product.Description;
            editProductDate.Text = product.Date.ToString();
            editProductInitialAmount.Text = "0";// số lượng sẽ thêm vào kho, không phải số lượng ban đầu
            editProductCapital.Text = "0";//đây là số vốn bỏ ra cho số lượng sẽ thêm vào kho, ko phải vốn ban đầu
            if (product.ImagePath != null)
            {
                //BitmapImage source = new BitmapImage(new Uri(product.ImagePath));
                //imgProduct.Source = source;
            }

            //Lấy tên loại sản phẩm tương úng
            Thread thread = new Thread(delegate ()
            {
                ProductType target = db.ProductTypes.Find(product.ProductType);

                //Lấy toàn bộ loại sản phẩm đưa vào combobox

                var productTypes = new ObservableCollection<string>(db.ProductTypes.Select(x => x.Name));
                Dispatcher.Invoke(() =>
                {
                    comboProductTypes.ItemsSource = productTypes;

                    // sau đó dò xem item nào đúng thì chọn
                    for (int i = 0; i < productTypes.Count; i++)
                    {
                        if (productTypes[i].Equals(target.Name))
                        {
                            comboProductTypes.SelectedIndex = i;
                            break;
                        }
                    }
                });
            });
            thread.Start();
        }

        #region xử lý hiệu ứng combobox
        ///Hiệu Ứng khi chọn
        private void ComboProductTypes_DropDownOpened(object sender, EventArgs e)
        {
            comboProductTypes.Background = Brushes.LightGray;
        }

        //hiệu ứng khi bỏ chọn
        private void ComboProductTypes_DropDownClosed(object sender, EventArgs e)
        {
            comboProductTypes.Background = Brushes.Transparent;
        }
        #endregion

        // Xử lý ô chỉ nhận giá trị số
        private void NumberOnly_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textbox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^[0-9]+");
        }

        //Thêm một loại sản phẩm

        private void BtnAddProductType_Click(object sender, RoutedEventArgs e)
        {
            var typeW = new ProductTypePage();
            typeW.RefeshProducttypeList = refreshCombo;
            NavigationService.Navigate(typeW);
        }

        //Thêm ảnh sản phẩm
        private void BtnAddImageProduct_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                txtURL.Text = op.FileName;
            }

            //Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();

            //if (openFileDialog.ShowDialog() == true)
            //{
            //    string filename = openFileDialog.FileName;
            //    try
            //    {
            //        BitmapImage source = new BitmapImage(new Uri(filename));
            //        imgProduct.Source = source;
            //        imgProduct.Tag = filename;
            //    }
            //    catch (Exception ex)
            //    {
            //        var dialogError = new Dialog() { Message = "Tập tin ảnh không hợp lệ" };
            //        dialogError.Owner = Window.GetWindow(this);
            //        dialogError.ShowDialog();
            //        return;
            //    }

            //}
        }

        //Sự kiện nút lưu(thao tác với cơ sở dữ liệu)
        private void BtnAddProductSave_Click(object sender, RoutedEventArgs e)
        {
            //kiểm tra dữ liệu có nhập đầy đủ nội dung không
            if (editProductName.Text.Length == 0
                || editProductId.Text.Length == 0
                || editProductPrice.Text.Length == 0
                || editProductInitialAmount.Text.Length == 0
                || editProductCapital.Text.Length == 0
                || editProductDate.Text.Length == 0
                || comboProductTypes.SelectedIndex == -1)
            {
                var dialogError1 = new Dialog() { Message = "Vui lòng nhập đầy đủ các thông tin" };
                dialogError1.Owner = Window.GetWindow(this);
                dialogError1.ShowDialog();
                return;
            }

            //Hiển thị thông báo xác nhận
            var dialogError = new Dialog() { Message = isEdit ? "Xác nhận sửa sản phầm" : "Thêm mới sản phẩm" };
            dialogError.Owner = Window.GetWindow(this);
            if (dialogError.ShowDialog() == true)
            {
                try
                {
                    var product = new Product()
                    {
                        Name = editProductName.Text,
                        Id = editProductId.Text,
                        Price = (long)double.Parse(editProductPrice.Text),
                        Date = DateTime.Parse(editProductDate.Text),
                        InitialAmount = int.Parse(editProductInitialAmount.Text),
                        CurrentAmount = int.Parse(editProductInitialAmount.Text),
                        Capital = (long)double.Parse(editProductCapital.Text),
                        Description = editProductDescription.Text.Length == 0 ? null : editProductDescription.Text,
                        //ImagePath = imgProduct.Tag == null ? null : ByteImageConverter.ImageToByte(imgProduct.Tag)
                        ImagePath = File.ReadAllBytes(txtURL.Text)
                    };

                    //Tìm id của loại sản phẩm đã chọn
                    ProductType type = db.ProductTypes.FirstOrDefault(x => x.Name == comboProductTypes.Text);
                    if (type != null)
                    {
                        product.ProductType = type.Id;
                        //Nếu sửa
                        if (isEdit)
                        {
                            var oldProduct = db.Products.Find(editProductId.Text);
                            oldProduct.Name = product.Name;
                            oldProduct.Price = product.Price;
                            oldProduct.Description = product.Description;
                            oldProduct.ImagePath = product.ImagePath;
                            oldProduct.Date = product.Date;
                            oldProduct.CurrentAmount += product.CurrentAmount;//thêm lượng mới ban đầu nhập vào cả tồn kho ban đầu và tồn kho hiện tại
                            oldProduct.InitialAmount += product.InitialAmount;
                            oldProduct.Capital += product.Capital;//giá vốn cũng thêm vào
                            if (oldProduct.ProductType != type.Id)//nếu có thay đổi mã sản phẩm
                            {
                                type.NumOfProduct++;//tăng mã mới
                                ProductType oldType = db.ProductTypes.Find(oldProduct.ProductType);
                                oldType.NumOfProduct--;//giảm mã cũ
                                oldProduct.ProductType = product.ProductType;
                            }
                        }

                        //Nếu thêm
                        else
                        {
                            db.Products.Add(product);
                            type.NumOfProduct++;
                        }
                        db.SaveChanges();
                    }
                    //nếu trang vừa r là danh sách sản phẩm thì cập nhật nó
                    if (RefreshProductList != null)
                    {
                        RefreshProductList.Invoke(true);
                    }

                }
                catch (Exception ex)
                {
                    var dialogError1 = new Dialog() { Message = "mã sản phẩm đã tồn tại" };
                    dialogError1.Owner = Window.GetWindow(this);
                    dialogError1.ShowDialog();
                }
            }
        }
        /// <summary>
        /// Định dạng giá cẻ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Price_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            //chuyển định dạng abc, xyz cho giá cả
            if (textBox.Text.Length > 0)
            {
                double value = 0;
                double.TryParse(textBox.Text, out value);
                textBox.Text = value.ToString("N0");
                textBox.CaretIndex = textBox.Text.Length;
            }
        }
        /// <summary>
        /// xử lý sự kiện nút làm mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRefesh_Click(object sender, RoutedEventArgs e)
        {
            editProductName.Clear();
            editProductId.Clear();
            editProductPrice.Clear();
            editProductDescription.Clear();
            editProductDate.Text = null;
            editProductInitialAmount.Clear();
            editProductCapital.Clear();
            comboProductTypes.SelectedIndex = -1;
            txtURL.Clear();
            //BitmapImage image = new BitmapImage();
            //image.BeginInit();
            //image.UriSource = new Uri("pack://application:,,/Images/Image.png");
            //image.EndInit();
            //imgProduct.Source = image;
            //imgProduct.Tag = null;
        }
        /// <summary>
        /// Làm mới combobox loại sản phẩm
        /// </summary>
        public void refreshCombo(bool Data)
        {
            if (Data) // Nếu có chỉnh sửa danh sách loại sản phẩm thì refresh combo
            {
                int oldIndex = comboProductTypes.SelectedIndex;

                // Get và hiển thị danh sách loại sản phẩm
                Thread getPTypes = new Thread(delegate ()
                {

                    var productTypes = new ObservableCollection<string>(db.ProductTypes.Select(x => x.Name));
                    Dispatcher.Invoke(() => {
                        comboProductTypes.ItemsSource = productTypes; // Tác động lên UI
                        if (oldIndex > 0) comboProductTypes.SelectedIndex = oldIndex;

                        // Cập nhật tiếp trang ở trước
                        if (RefreshProductList != null)
                        {
                            RefreshProductList.Invoke(true);
                        }
                    });
                });
                getPTypes.Start();
            }
        }
    }
}

