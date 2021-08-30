using Abp.Application.Services;
using ruito.MultiTenancy.Dto;

namespace ruito.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

