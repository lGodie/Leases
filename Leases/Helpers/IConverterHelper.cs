using System.Threading.Tasks;
using Leases.Data.Entities;
using Leases.Models;

namespace Leases.Helpers
{
    public interface IConverterHelper
    {
        Task<Property> ToPropertyAsync(PropertyDto model, bool isNew);

        PropertyDto ToPropertyDto(Property property);

        Task<Contract> ToContractAsync(ContractDto model, bool isNew);

        ContractDto ToContractDto(Contract contract);
    }
}