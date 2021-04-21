using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;
using CursoAPI.Controllers;
using CursoAPI.Models;


namespace CursoTeste
{
    public class CategoriasControllerTeste
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<DbSet<Context>> _mockContext;
        private readonly Categoria _categoria;

        public CategoriasControllerTeste()
        {

            _mockSet = new Mock<DbSet<Categoria>>();

            _mockContext = new Mock<DbSet<Context>>();

            _categoria = new Categoria { Id = 1, Descricao = "Teste Categoria" };

            //_mockContext.Setup(m => m.Categorias).Returns(_mockSet.Object);

            //_mockContext.Setup(m => m.Categorias.FindAsync(1)).ReturnAsync(_categoria);


        }


        [Fact]
        public async Task Get_Categoria()
        {

            CategoriaControllerAPI service = new CategoriaControllerAPI(_mockContext.Object);

            await service.GetCategoria(1);

            _mockSet.Verify(m => m.FindAsync(1), Times.Once());


        }

        
    }
}
