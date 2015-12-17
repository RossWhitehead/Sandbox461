using AutoMapper;
using Sandbox461.Models;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace Sandbox461
{
    public class AutoMapperConfig
    {
        public static void CreateMaps()
        {
            Mapper.CreateMap<HttpPostedFileBase, SupportedDocument>()
                .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.InputStream));

            Mapper.CreateMap<Stream, byte[]>()
                .ConstructUsing(s =>
                {
                    MemoryStream target = new MemoryStream();
                    s.CopyTo(target);
                    return target.ToArray();
                });
        }
    }
}
