using WebApp.Data.Repository.IRepository;
using WebApp.Models;

namespace WebApp.Services
{
    public class AppService
    {
        private readonly Random _random = new Random();   
        private readonly IUnitOfWork _unitOfWork;
        private readonly List<Mark> markList = new List<Mark>();
        private readonly List<RepairCost> repairCostList = new List<RepairCost>();
        private readonly List<Status> statusList = new List<Status>();
        private readonly List<Address> addressList = new List<Address>();
        private readonly List<DeviceType> deviceTypeList = new List<DeviceType>();

        public AppService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            markList = _unitOfWork.Mark.GetAll().ToList();
            repairCostList = _unitOfWork.RepairCost.GetAll().ToList();
            statusList = _unitOfWork.Status.GetAll().ToList();
            addressList = _unitOfWork.Address.GetAll().ToList();
            deviceTypeList = _unitOfWork.DeviceType.GetAll().ToList();
        }

        public Repair GetRepair()
        {
            Repair repair = new Repair();
            repair.Describe = GetDescribe();
            repair.PickupDate = RandomDay();
            repair.Tracking = GetTracking();
            repair.Warranty = GetWarranty();

            repair.Mark = GetMark();
            repair.Address = GetAddress();  
            repair.DeviceType = GetDeviceType();
            repair.Status = GetStatus();
            repair.RepairCost = GetRepairCost();    

            return repair;
        }

        private Address GetAddress()
        {
            Address address = new Address();    

            var index = _random.Next(addressList.Count); ;
            address = addressList[index];

            return address;
        }

        private DeviceType GetDeviceType()
        {
            DeviceType deviceType = new DeviceType();

            var index = _random.Next(deviceTypeList.Count);
            deviceType = deviceTypeList[index];

            return deviceType;
        }

        private Mark GetMark()
        {
            Mark mark = new Mark();

            var index = _random.Next(markList.Count);
            mark = markList[index];

            return mark;
        }

        private RepairCost GetRepairCost()
        {
            RepairCost repairCost = new RepairCost();

            var index = _random.Next(repairCostList.Count);
            repairCost = repairCostList[index];

            return repairCost;
        }

        private Status GetStatus()
        {
            Status status = new Status();

            var index = _random.Next(statusList.Count);
            status = statusList[index];

            return status;
        }

        private string GetTracking()
        {
            List<string> trackingList = new List<string>();
            trackingList.Add("https://inpost.pl/sledzenie-przesylek?number=873234987612340872938732");
            trackingList.Add("https://inpost.pl/sledzenie-przesylek?number=967745675675673485676577");
            trackingList.Add("https://inpost.pl/sledzenie-przesylek?number=856745676574567675677674");
            trackingList.Add("https://inpost.pl/sledzenie-przesylek?number=645647434564565467675475");
            trackingList.Add("https://inpost.pl/sledzenie-przesylek?number=875785735657856789867678");
            trackingList.Add("https://inpost.pl/sledzenie-przesylek?number=567895768567987689674797");

            int index = _random.Next(trackingList.Count);

            string tracking = trackingList[index];

            return tracking;
        }


        private string GetWarranty() 
        {
            List<string> warrantyList = new List<string>();
            warrantyList.Add("24 months");
            warrantyList.Add("12 months");
            warrantyList.Add("8 months");
            warrantyList.Add("6 months");
            warrantyList.Add("3 months");

            int index = _random.Next(warrantyList.Count);

            string warranty = warrantyList[index];

            return warranty;
        }

        private string GetDescribe()
        {
            List<string> describeList = new List<string>();
            describeList.Add("Uszkodzona nóżka.");
            describeList.Add("Uszkodzony silnik.");
            describeList.Add("Uszkodzona szyba.");
            describeList.Add("Uszkodzone drzwi.");      

            int index = _random.Next(describeList.Count);

            string describe = describeList[index];
           
            return describe;
        }

        private DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(_random.Next(range));
        }
    }
    
}
