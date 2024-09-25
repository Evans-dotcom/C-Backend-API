//using AutoMapper;
//using System;
//using UserAuthenticate.dtos;
//using UserAuthenticate.models;

//namespace UserAuthenticate.mappings
//{
//    public class MappingProfile : Profile
//    {
//        public MappingProfile()
//        {
//            CreateMap<DriverDto, Driver>()
//                .ForMember(dest => dest.CurrentLongitude, opt => opt.MapFrom(src => Convert.ToDecimal(src.CurrentLongitude)))
//                .ForMember(dest => dest.CurrentLatitude, opt => opt.MapFrom(src => Convert.ToDecimal(src.CurrentLatitude)))
//                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => DateTime.UtcNow))
//                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => true))
//                .ForMember(dest => dest.Enabled, opt => opt.MapFrom(src => true))
//                .ForMember(dest => dest.GUID, opt => opt.MapFrom(src => Guid.NewGuid()));
//        }
//    }
//}
