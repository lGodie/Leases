using System.Collections.Generic;
using System.Threading.Tasks;
using Leases.Data;
using Leases.Data.Entities;
using Leases.Models;

namespace Leases.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        private readonly DataContext _dataContext;
        private readonly ICombosHelper _combosHelper;

        public ConverterHelper(
            DataContext dataContext,
            ICombosHelper combosHelper)
        {
            _dataContext = dataContext;
            _combosHelper = combosHelper;
        }

        public async Task<Contract> ToContractAsync(ContractDto model, bool isNew)
        {
            return new Contract
            {
                EndDate = model.EndDate,
                IsActive = model.IsActive,
                Lessee = await _dataContext.Lessees.FindAsync(model.LesseeId),
                Owner = await _dataContext.Owners.FindAsync(model.OwnerId),
                Price = model.Price,
                Property = await _dataContext.Properties.FindAsync(model.PropertyId),
                Remarks = model.Remarks,
                StartDate = model.StartDate,
                Id = isNew ? 0 : model.Id
            };
        }

        public async Task<Property> ToPropertyAsync(PropertyDto model, bool isNew)
        {
            return new Property
            {
                Address = model.Address,
                Contracts = isNew ? new List<Contract>() : model.Contracts,
                HasParkingLot = model.HasParkingLot,
                Id = isNew ? 0 : model.Id,
                IsAvailable = model.IsAvailable,
                Neighborhood = model.Neighborhood,
                Owner = await _dataContext.Owners.FindAsync(model.OwnerId),
                Price = model.Price,
                PropertyImages = model.PropertyImages,
                PropertyType = await _dataContext.PropertyTypes.FindAsync(model.PropertyTypeId),
                Remarks = model.Remarks,
                Rooms = model.Rooms,
                SquareMeters = model.SquareMeters,
                Stratum = model.Stratum
            };
        }

        public PropertyDto ToPropertyDto(Property property)
        {
            return new PropertyDto
            {
                Address = property.Address,
                Contracts = property.Contracts,
                HasParkingLot = property.HasParkingLot,
                Id = property.Id,
                IsAvailable = property.IsAvailable,
                Neighborhood = property.Neighborhood,
                Owner = property.Owner,
                Price = property.Price,
                PropertyImages = property.PropertyImages,
                PropertyType = property.PropertyType,
                Remarks = property.Remarks,
                Rooms = property.Rooms,
                SquareMeters = property.SquareMeters,
                Stratum = property.Stratum,
                OwnerId = property.Owner.Id,
                PropertyTypeId = property.PropertyType.Id,
                PropertyTypes = _combosHelper.GetComboPropertyTypes()
            };
        }

        public ContractDto ToContractDto(Contract contract)
        {
            return new ContractDto
            {
                EndDate = contract.EndDate,
                IsActive = contract.IsActive,
                LesseeId = contract.Lessee.Id,
                OwnerId = contract.Owner.Id,
                Price = contract.Price,
                Remarks = contract.Remarks,
                StartDate = contract.StartDate,
                Id = contract.Id,
                Lessees = _combosHelper.GetComboLessees(),
                PropertyId = contract.Property.Id
            };
        }
    }
}