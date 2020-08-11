using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CakeShop
{
    /// <summary>
    /// Interaction logic for ProductDetailPage.xaml
    /// </summary>
    public partial class ProductDetailPage : Page
    {
        //kết nố tới csdl
        CakeShop_SystemEntities db = new CakeShop_SystemEntities();

        //Delegate để refresh danh sách sản phẩm
        public delegate void delegateRefreshproductList(bool Data);
        public delegateRefreshproductList RefreshProuctList;

        //sản phẩm
        public Product product;

        //Dannh sách hóa đơn liên quan
        public ObservableCollection<Bill> bills;

        public ProductDetailPage(Product _product)
        {
            InitializeComponent();
            product = _product;
            refresh(true);
        }

        /// <summary>
        /// /làm mới thông ton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void refresh(bool Data)
        {
            if(Data)// nếu vửa sửa xong
            {
                //nạp lại đối tượng mới
                product = db.Products.Find(product.Id);

                //làm mới danh sách ở trang trước(delegate 2 cấp)
                if(RefreshProuctList !=null)
                {
                    RefreshProuctList.Invoke(true);
                }
            }
            //Đưa thông tin lên UI
            editProductName.Text = product.Name;
            editProductId.Text = product.Id;
            editProductPrice.Text = product.Price.ToString("N0");
            if (editProductDescription != null) editProductDescription.Text = product.Description;
            editProductDate.Text = product.Date.ToString();
            editAmount.Text = product.CurrentAmount + "/" + product.InitialAmount;
            editCapital.Text = product.Capital.ToString("N0");

            if(product.ImagePath !=null)
            {
                imgProduct.Source = ByteImageConverter.ByteToImage(product.ImagePath); 
                //BitmapImage source = new BitmapImage(new Uri(product.ImagePath));
                //imgProduct.Source = source;
            }
            // Lấy tên loại sản phẩm và các hóa đơn liên quan
            Thread thread = new Thread(delegate ()
            {
                try
                {
                    
                    string productTypeName = db.ProductTypes.Find(product.ProductType).Name;                // Lấy tên loại sản phẩm
                    bills = new ObservableCollection<Bill>(db.Bills.Where(x => x.ProductId == product.Id)); // Lấy danh sách hóa đơn

                    // Đưa lên UI
                    Dispatcher.Invoke(() => {
                        editProductType.Text = productTypeName;
                        listBill.ItemsSource = bills;

                        // Hiện thông báo nếu không có Bill nào
                        if (bills.Count == 0) noBillAnnounce.Visibility = Visibility.Visible;
                    });
                }
                catch (Exception) { }
            });
            thread.Start();

        }
        /// <summary>
        /// Sửa sản phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void  BtnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            if(RefreshProuctList !=null)
            {
                RefreshProuctList.Invoke(true);
            }
            var edit = new NewProductPage(product);
            edit.RefreshProductList = refresh;
            NavigationService.Navigate(edit);
        }
        /// <summary>
        /// xóa sản phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRemoveProduct_Click(object sender, RoutedEventArgs e)
        {
            //Hiện thông báo xác nhận
            var dialog = new Dialog() { Message = "Xóa sản phẩm này?" };
            dialog.Owner = Window.GetWindow(this);
            if (dialog.ShowDialog() == false) return;

            #region Thao tác vs CSDL
            //Tìm đối tượng tương ứng trong csdl và xóa
            try
            {
                //giảm số sản phẩm của loại sản phẩm
                ProductType type = db.ProductTypes.First(x => x.Id == product.ProductType);
                type.NumOfProduct--;

                //sau đó xóa
                Product productfromDB = db.Products.Find(product.Id);
                db.Products.Remove(productfromDB);
                db.SaveChanges();

                //Cập nhật lên ListView
                if(RefreshProuctList !=null)
                {
                    RefreshProuctList.Invoke(true);
                    btnEditProduct.IsEnabled = false;
                    btnRemoveProduct.Content = "Đã xóa";
                    btnRemoveProduct.IsEnabled = false;
                    if (NavigationService.CanGoBack) NavigationService.GoBack();
                }
            }
            catch (Exception) { }
            #endregion
        }
        //List hóa đơn liên quan tới sản phẩm
        private void listBil_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Đi đến danh sách hóa đơn và chọn vào hóa đơn đó
            var billList = new BillPage(listBill.SelectedItem as Bill);
            NavigationService.Navigate(billList);
        }
        /// <summary>
        /// Thêm đơn hàng với sản phẩm hiện tại
        /// </summary>
        private void BtnAddBill_Click(object sender, RoutedEventArgs e)
        {
            var addBill = new NewBillPage(product);
            NavigationService.Navigate(addBill);
        }

        /// <summary>
        /// Xem thống kê tăng trưởng doanh thu của sản phẩm
        /// </summary>
        private void BtnStatistic_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StatisticGrowing(product));
        }

       
    }
}
