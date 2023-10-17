using AutoRepairShop.Core.dtos;
using AutoRepairShop.Core.Entities.Interfaces;
using AutoRepairShop.Core.Mappers;
using AutoRepairShop.Core.Repositories;
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
            _allData = new List<TEntity>(_repository.GetAll());
        }

        public TEntity[] Select(int count, int startIndex = 0)
        {
            var data = new List<TEntity>(_allData.ToArray());

            var lastIndex = data.Count - 1 < 0 ? 0 : data.Count - 1;
            startIndex = startIndex < data.Count ? startIndex : lastIndex;
            count = count + startIndex > data.Count ? data.Count - startIndex : count;

            return data.GetRange(startIndex, count).ToArray();
        }

        public TEntity[] Select(SelectDto dto, int count, int startIndex = 0)
        {
            var data = new List<TEntity>(_allData.ToArray());
            if (dto.Filter != string.Empty)
                data = Filter(data, dto.Filter, dto.FilterColumn);
            if (dto.Sort != SelectDto.TypeSort.Null)
                data = Sort(data, dto.Sort, dto.SortColumn);
            if (dto.Search != string.Empty)
                data = Search(data, dto.Search, dto.SearchColumn);

            var lastIndex = data.Count - 1 < 0 ? 0 : data.Count - 1;
            startIndex = startIndex < data.Count ? startIndex : lastIndex;
            count = count + startIndex > data.Count ? data.Count - startIndex : count;

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
                if (sort == SelectDto.TypeSort.DECS)
                    { var t = x; x = y; y = t; }
                bool xIsNumber = int.TryParse(x[column], out int xNumber);
                bool yIsNumber = int.TryParse(y[column], out int yNumber);

                if (xIsNumber && yIsNumber)
                    return xNumber.CompareTo(yNumber);
                else
                    return x[column].CompareTo(y[column]);
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
