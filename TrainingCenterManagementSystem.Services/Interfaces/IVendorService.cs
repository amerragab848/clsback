using System;
using System.Collections.Generic;
using System.Text;
using TrainingCenterManagementSystem.Core.Dtos;

namespace TrainingCenterManagementSystem.Services.Interfaces
{
    public interface IVendorService
    {
        VendorsDTO AddVendor(VendorsDTO entity);
        void DeleteVendor(VendorsDTO entity);
        VendorsDTO GetVendorById(long id);
        List<VendorsDTO> GetAllVendor();
        void UpdateVendor(VendorsDTO entity);
    }
}
