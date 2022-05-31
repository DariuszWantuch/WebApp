using Microsoft.AspNetCore.Identity;
using WebApp.Data.EntityFramework.Repository.IRepository;
using WebApp.Models;

namespace WebApp.Services
{
    public class AppService
    {
        private readonly Random _random = new Random();   
        private readonly IEFUnitOfWork _unitOfWork;
        private readonly List<Mark> markList;
        private readonly List<RepairCost> repairCostList;
        private readonly List<Status> statusList;
        private readonly List<Address> addressList;
        private readonly List<DeviceType> deviceTypeList;
        private readonly List<IdentityUser> identityUserList;

        public AppService(IEFUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            identityUserList = _unitOfWork.User.GetAll().ToList();
            markList = _unitOfWork.Mark.GetAll().ToList();
            repairCostList = _unitOfWork.RepairCost.GetAll().ToList();
            statusList = _unitOfWork.Status.GetAll().ToList();
            addressList = _unitOfWork.Address.GetAll().ToList();
            deviceTypeList = _unitOfWork.DeviceType.GetAll().ToList();
        }

        public Repair GetRepair()
        {
            Repair repair = new Repair();
            repair.Id = GenerateID();
            repair.Describe = GetDescribe();
            repair.PickupDate = RandomDay();
            repair.ReportDate = repair.PickupDate.AddDays(-3);
            repair.Tracking = GetTracking();
            repair.Warranty = GetWarranty();

            repair.Mark = GetMark();
            repair.Address = GetAddress();
            repair.DeviceType = GetDeviceType();
            repair.Status = GetStatus();
            repair.RepairCost = GetRepairCost();
            repair.IdentityUser = GetUser();
            repair.DeviceModel = GetDeviceModel();

            repair.MarkId = GetMark().Id;
            repair.AddressId = GetAddress().Id;
            repair.DeviceTypeId = GetDeviceType().Id;
            repair.StatusId = GetStatus().Id;
            repair.RepairCostId = GetRepairCost().Id;
            repair.UserId = GetUser().Id;

            return repair;
        }

        private Address GetAddress()
        {
            Address address = new Address();    

            var index = _random.Next(addressList.Count - 1); ;
            address = addressList[index];

            return address;
        }

        private DeviceType GetDeviceType()
        {
            DeviceType deviceType = new DeviceType();

            var index = _random.Next(deviceTypeList.Count - 1 );
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

            var index = _random.Next(repairCostList.Count - 1);
            repairCost = repairCostList[index];

            return repairCost;
        }

        private Status GetStatus()
        {
            Status status = new Status();

            var index = _random.Next(statusList.Count - 1);
            status = statusList[index];

            return status;
        }

        private IdentityUser GetUser()
        {
            IdentityUser user = new IdentityUser();

            var index = _random.Next(identityUserList.Count - 1);
            user = identityUserList[index];

            return user;
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

            int index = _random.Next(trackingList.Count - 1);

            string tracking = trackingList[index];

            return tracking;
        }

        private string GetDeviceModel()
        {
            List<string> modelList = new List<string>();
            modelList.Add("SCVB67");
            modelList.Add("GHFGH6");
            modelList.Add("GDH456JHF");
            modelList.Add("5656DGDG76");
            modelList.Add("DFG546DFG");
            modelList.Add("DFGDFY556HF");
            modelList.Add("45645DG56CFG5");


            int index = _random.Next(modelList.Count - 1);

            string model = modelList[index];

            return model;
        }


        private string GetWarranty() 
        {
            List<string> warrantyList = new List<string>();
            warrantyList.Add("24 months");
            warrantyList.Add("12 months");
            warrantyList.Add("8 months");
            warrantyList.Add("6 months");
            warrantyList.Add("3 months");

            int index = _random.Next(warrantyList.Count - 1);

            string warranty = warrantyList[index];

            return warranty;
        }

        private Guid GenerateID()
        {
            return Guid.NewGuid();
        }

        private string GetDescribe()
        {
            List<string> describeList = new List<string>();
            describeList.Add("Uszkodzona nóżka.");
            describeList.Add("Uszkodzony silnik.");
            describeList.Add("Uszkodzona szyba.");
            describeList.Add("Uszkodzone drzwi.");      

            int index = _random.Next(describeList.Count - 1);

            string describe = describeList[index];
           
            return describe;
        }

        private DateTime RandomDay()
        {
            DateTime start = new DateTime(2022, 7, 1);
            int range = (DateTime.Now.AddDays(90) - start).Days;
            return start.AddDays(_random.Next(range));
        }
    }
    
}
