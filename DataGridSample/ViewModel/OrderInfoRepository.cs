using DataGridSample;
using Syncfusion.Maui.Data;
using Syncfusion.Maui.DataGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridSample
{

    public class OrderInfoRepository : INotifyPropertyChanged
    {
        private ObservableCollection<OrderInfo> orderInfo;

        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderInfo; }
            set { this.orderInfo = value; this.RaisePropertyChanged("OrderInfoCollection"); }
             
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public OrderInfoRepository()
        {
            orderInfo = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }
        
        private void RaisePropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }


        public void GenerateOrders()
        {

            orderInfo.Add(new OrderInfo(1001, "Anders", "India", "ALFKI", "Berlin", true, 1001, "Maria Anders", "Germany", "ALFKI", "Berlin", true, "1001", "Maria Anders", "Germany", "ALFKI", "Berlin", true));
            orderInfo.Add(new OrderInfo(1002, "Jose", "Germany", "ALFKI", "Chennai", false, 1002, "Maria Anders", "Germany", "ALFKI", "Berlin", true, "1002", "Maria Anders", "Germany", "ALFKI", "Berlin", true));
            orderInfo.Add(new OrderInfo(1003, "Adams", "India", "ALFKI", "Tokyo", true, 1003, "Sanjay", "France", "Sudhar", "India", false, "1003", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1004, "Tim", "Germany", "Som", "Berlin", false, 1004, "Maria Anders", "Germany", "ALFKI", "Berlin", true, "1004", "Maria Anders", "Germany", "ALFKI", "Berlin", true));
            orderInfo.Add(new OrderInfo(1005, "Maria", "France", "ALFKI", "Paris", true, 1005, "Maria Anders", "Germany", "ALFKI", "Berlin", true, "1005", "Maria Anders", "Germany", "ALFKI", "Berlin", true));
            orderInfo.Add(new OrderInfo(1006, "Kumar", "Germany", "ALFKI", "Berlin", false, 1006, "Maria Anders", "Germany", "ALFKI", "Berlin", true, "1006", "Maria Anders", "Germany", "ALFKI", "Berlin", true));
            orderInfo.Add(new OrderInfo(1007, "Robert", "Germany", "ALFKI", "Berlin", true, 1007, "Sanjay", "France", "Sudhar", "India", true, "1007", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1008, "Maria", "Nepal", "ALFKI", "Berlin", false, 1008, "Sanjay", "France", "Sudhar", "India", false, "1008", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1009, "Maria", "Nepal", "ALFKI", "Berlin", true, 1009, "Sanjay", "France", "Sudhar", "India", false, "1009", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1010, "Adams", "Nepal", "ALFKI", "Berlin", false, 1010, "Sanjay", "France", "Sudhar", "India", false, "1010", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1011, "Maria", "Germany", "ALFKI", "Berlin", true, 1011, "Sanjay", "France", "Sudhar", "India", false, "1011", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1012, "Maria", "India", "ALFKI", "Berlin", false, 1012, "Sanjay", "France", "Sudhar", "India", true, "1012", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1013, "Maria", "Germany", "ALFKI", "Berlin", true, 1013, "Sanjay", "France", "Sudhar", "India", false, "1013", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1014, "Adams", "India", "ALFKI", "Berlin", false, 1014, "Sanjay", "France", "Sudhar", "India", false, "1014", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1015, "Maria", "Germany", "ALFKI", "Berlin", true, 1015, "Sanjay", "France", "Sudhar", "India", false, "1015", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1016, "Adams", "Germany", "ALFKI", "Berlin", false, 1016, "Sanjay", "France", "Sudhar", "India", true, "1016", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1017, "Maria", "Japan", "ALFKI", "Berlin", true, 1017, "Sanjay", "France", "Sudhar", "India", false, "1017", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1018, "Maria", "Japan", "ALFKI", "Berlin", false, 1018, "Sanjay", "France", "Sudhar", "India", false, "1018", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1019, "Adams", "India", "ALFKI", "Berlin", true, 1019, "Sanjay", "France", "Sudhar", "India", false, "1019", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1020, "Adams", "Germany", "ALFKI", "Berlin", false, 1020, "Sanjay", "France", "Sudhar", "India", true, "1020", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1021, "Adams", "Germany", "ALFKI", "Berlin", true, 1021, "Sanjay", "France", "Sudhar", "India", false, "1021", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1022, "Maria", "Germany", "ALFKI", "Berlin", false, 1022, "Sanjay", "France", "Sudhar", "India", false, "1022", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1023, "Maria", "Germany", "ALFKI", "Berlin", true, 1023, "Sanjay", "France", "Sudhar", "India", false, "1023", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1024, "Maria", "India", "ALFKI", "Berlin", false, 1024, "Sanjay", "France", "Sudhar", "India", false, "1024", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1025, "Maria", "Germany", "ALFKI", "Berlin", true, 1025, "Sanjay", "France", "Sudhar", "India", false, "1025", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1026, "Adams", "Germany", "ALFKI", "Berlin", false, 1026, "Sanjay", "France", "Sudhar", "India", true, "1026", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1027, "Maria", "Germany", "ALFKI", "Berlin", true, 1027, "Sanjay", "France", "Sudhar", "India", false, "1027", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1028, "Adams", "India", "ALFKI", "Berlin", false, 1028, "Sanjay", "France", "Sudhar", "India", false, "1028", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1029, "Maria", "Germany", "ALFKI", "Berlin", true, 1029, "Sanjay", "France", "Sudhar", "India", true, "1029", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1030, "Adams", "Germany", "ALFKI", "Berlin", false, 1030, "Sanjay", "France", "Sudhar", "India", false, "1030", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1031, "Maria Anders", "Germany", "ALFKI", "Berlin", true, 1031, "Sanjay", "France", "Sudhar", "India", false, "1031", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1032, "Tim Adams", "Germany", "ALFKI", "Berlin", false, 1032, "Sanjay", "France", "Sudhar", "India", false, "1032", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1033, "Maria Anders", "Germany", "ALFKI", "Berlin", true, 1033, "Sanjay", "France", "Sudhar", "India", true, "1033", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1034, "Maria Anders", "Germany", "ALFKI", "Berlin", false, 1034, "Sanjay", "France", "Sudhar", "India", true, "1034", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1035, "Tim Adams", "Germany", "ALFKI", "Berlin", true, 1035, "Sanjay", "France", "Sudhar", "India", false, "1035", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1036, "Tim Adams", "India", "ALFKI", "Berlin", false, 1036, "Sanjay", "France", "Sudhar", "India", false, "1036", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F.", false));
        }

    }
}
