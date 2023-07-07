using CrudManage.Data;
using CrudManage.Models;
using CrudManage.Repositorio.Interface;
using Microsoft.EntityFrameworkCore;

namespace CrudManage.Repositorio
{
    public class UsuarioRepositorio : IUsuario
    {
        private readonly ValorRendaDBContext _dbContext;
        public UsuarioRepositorio(ValorRendaDBContext valorRendaDBContext)
        {
            _dbContext = valorRendaDBContext;
            
        }

        public async Task<UsuarioModel> BuscarPorId(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }
        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            //Salva o Usuario na base de dados
            await _dbContext.SaveChangesAsync();
            return usuario;
        }
        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);
            if(usuarioPorId == null)
            {
                throw new Exception($"Usuário para o Id:{id} não foi encontrado no banco de dados.");
            }
            usuarioPorId.Name = usuario.Name;
            usuarioPorId.DataNascimento = usuario.DataNascimento;


            _dbContext.Usuarios.Update(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return usuarioPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);
            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário para o Id:{id} não foi encontrado no banco de dados.");
            }
            _dbContext.Usuarios.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();
            return true;

        }

     

      
    }
}
