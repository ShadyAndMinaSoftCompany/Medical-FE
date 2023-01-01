using AutoMapper;

namespace BackendCore.Service.Mapping
{
    public partial class MappingService : Profile
    {
        public MappingService()
        {
            #region Identity Profiles

            MapUser();
            MapPermission();
            MapRole();
            MapLoginHistory();
            MapBusiness();
            #endregion

            #region Lookups Profiles



            #endregion

            #region Business Profiles

            MapAttachment();

            #endregion

            #region Common Profiles

            MapFile();

            #endregion

        }
    }
}