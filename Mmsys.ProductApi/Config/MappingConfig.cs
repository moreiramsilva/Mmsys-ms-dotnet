using Mmsys.ProductManagementApi.DTO;
using AutoMapper;
using Mmsys.ProductManagementApi.Model.DAO;

namespace Mmsys.ProductManagementApi.Config
{
    public class MappingConfig
    {
        //MAP PARA REALIZAR A CONVERSÃO DE MODEL PARA DTO E VICE-VERSA
        public static MapperConfiguration RegistrerMaps()
        {

            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap
                <ProductDTO, Product>();
                config.CreateMap
                <Product, ProductDTO>();
                config.CreateMap
                <CompanyDTO, Company>();
                config.CreateMap
                <Company, CompanyDTO>();
            } 
            ); 


            return mappingConfig;
        }

    }
}
