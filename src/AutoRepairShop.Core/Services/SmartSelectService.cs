using AutoRepairShop.Core.dtos;
using AutoRepairShop.Core.Entities.Interfaces;
using AutoRepairShop.Core.Mappers;
using AutoRepairShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRepairShop.Core.Services
{
    public class SmartSelectService<TEntity>
        where TEntity : IEntity
    {
        private IRepository<TEntity> _repository;
        private IStringMapper<TEntity> _mapper;
        private List<TEntity> _allData = new List<TEntity>();

        public int Count => _allData.Count;

        public SmartSelectService(IRepository<TEntity> repository, IStringMapper<TEntity> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void UpdateData()
        {
            
        }

        public TEntity[] Select(SelectDto dto, int count, int startIndex = 0)
        {
            var data = new List<TEntity>(_allData.ToArray());
            if (dto.Filter != string.Empty)
                data = Filter(data, dto.Filter, dto.FilterColumn);
            if (dto.Filter != string.Empty)
                data = Sort(data, dto.Sort, dto.SortColumn);
            if (dto.Filter != string.Empty)
                data = Search(data, dto.Filter, dto.FilterColumn);
            return data.GetRange(startIndex, count).ToArray();
        }

        private List<TEntity> Filter(List<TEntity> array, string filter, int column)
        {
            var data = array.ConvertAll(entity => _mapper.ToString(entity));
            array = data.Where(row => row[column] == filter)
                .ToList().ConvertAll(entity => _mapper.ToEntity(entity));
            return array;
        }

        private List<TEntity> Sort(List<TEntity> array, SelectDto.TypeSort sort, int column)
        {
            var data = array.ConvertAll(entity => _mapper.ToString(entity));
            data.Sort((x, y) =>
            {
                switch (sort)
                {
                    case SelectDto.TypeSort.ACS:
                        return string.Compare(x[column], y[column], true);
                    case SelectDto.TypeSort.DECS:
                        return string.Compare(y[column], x[column], true);
                }
                return 0;
            });
            array = data.ToList().ConvertAll(entity => _mapper.ToEntity(entity));
            return array;
        }

        private List<TEntity> Search(List<TEntity> array, string search, int column)
        {
            var data = array.ConvertAll(entity => _mapper.ToString(entity));
            data.Sort((x, y) =>
            {
                var distX = SearchService.GetLevenshteinDistance(x[column], search);
                var distY = SearchService.GetLevenshteinDistance(y[column], search);
                return distX.CompareTo(distY);
            });
            array = data.ToList().ConvertAll(entity => _mapper.ToEntity(entity));
            return array;
        }
    }
}
