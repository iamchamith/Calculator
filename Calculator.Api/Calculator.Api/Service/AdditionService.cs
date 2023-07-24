using Calculator.Api.Domain;
using Calculator.Api.Dtos;
using Calculator.Api.Persistance;

namespace Calculator.Api.Service
{

    public interface IAdditionService
    {
        Task<double> Add(AdditionDto dto);
    }

    public class AdditionService: IAdditionService
    {
        private readonly CalculatorDbContext _calculatorDbContext;

        public AdditionService(CalculatorDbContext calculatorDbContext)
        {
            _calculatorDbContext = calculatorDbContext;
        }

        public async Task<double> Add(AdditionDto dto)
        {
            var result = dto.FirstNumber + dto.SecondNumber;
            await _calculatorDbContext.AddAsync(new Addition
            {
                FirstNumber = dto.FirstNumber,
                SecondNumber = dto.SecondNumber,
                Result = result
            });
            await _calculatorDbContext.SaveChangesAsync();
            return result;
        }
    }
}
