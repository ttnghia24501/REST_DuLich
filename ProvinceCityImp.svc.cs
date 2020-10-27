using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace REST_DuLich
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProvinceCityImp" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProvinceCityImp.svc or ProvinceCityImp.svc.cs at the Solution Explorer and start debugging.
    public class ProvinceCityImp : IProvinceCityImp
    {
        DuLichDataContext data = new DuLichDataContext();

        public bool CreateProvinceCity(ProvinceCity city)
        {
            try
            {
                data.ProvinceCities.InsertOnSubmit(city);
                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteProvinceCity(int id)
        {
            try
            {
                ProvinceCity city = (from ProvinceCity in data.ProvinceCities
                                     where ProvinceCity.MaTinh == id
                                     select ProvinceCity).Single();

                data.ProvinceCities.DeleteOnSubmit(city);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ProvinceCity> GetProvinceCities()
        {
            try
            {
                return (from dulich in data.ProvinceCities select dulich).ToList();
            }
            catch { return null; }
        }

        public bool UpdateProvinceCity(ProvinceCity city)
        {
            try
            {
                var t = (from ProvinceCity in data.ProvinceCities
                         where ProvinceCity.MaTinh == city.MaTinh
                         select ProvinceCity).Single();
                t.MaTinh = city.MaTinh;
                t.TenTinh = city.TenTinh;
                t.TenTp = city.TenTp;

                data.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
