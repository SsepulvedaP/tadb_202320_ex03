using tadb_202320_ex03.DbContexts;
using tadb_202320_ex03.Helpers;
using tadb_202320_ex03.Interfaces;
using tadb_202320_ex03.Models;
using Npgsql;
using System.Data;

namespace tadb_202320_ex03.Repositories
{
    public class CargadoresRepository : ICargadoresRepository
    {
        private readonly PgsqlDbContext contextoDB;

        public CargadoresRepository(PgsqlDbContext unContexto)
        {
            contextoDB = unContexto;
        }

        //Metodo que obtiene todos los cargadores 
        public async Task<IEnumerable<Cargadores>> GetAllAsync()
        {
            var conexion = contextoDB.CreateConnection();

            string sentenciaSQL = "SELECT c.id_cargador id, c.voltaje voltaje " +
                                "FROM cargadores c " +
                                "ORDER BY c.id_cargador";

            var ResultadoCargadores = await conexion.QueryAsync<Cargadores>(sentenciaSQL,
                                    new DynamicParameters());

            foreach (Cargadores unCargadores in ResultadoCargadores)
                unCargadores.voltaje = await GetAssociatedLocationAsync(unCargadores.Id);

            return ResultadoCargadores;
        }

        //2.Obtener un cargador por id
         public async Task<Cargadores> GetByIdAsync(int id_cargador)
        {
            Cargadores unCargadores = new();

            var conexion = contextoDB.CreateConnection();

            DynamicParameters parametrosSentencia = new();
            parametrosSentencia.Add("@id_cargador", id_cargador,
                                    DbType.Int32, ParameterDirection.Input);

            string sentenciaSQL = "SELECT c.id_cargador id, c.voltaje voltaje " +
                "FROM c_Cargadores c " +
                "WHERE c.id_cargador = @id_cargador";

            var resultado = await conexion.QueryAsync<Cargadores>(sentenciaSQL,
                                parametrosSentencia);

            if (resultado.Any())
            {
                unCargadores = resultado.First();
                unCargadores.voltaje = await GetAssociatedLocationAsync(unCargadores.id_cargador);
            }

            return unCargadores;
        }
        //3.Crear un nuevo cargador 
        //4.Actualizar un cargador existente 
        //5.Eliminar un cargador existente 
        //6.Obtener autobuses registrados
        //7.Obtener autobús por Id 
        //8.Crear un nuevo autobús 
        //9.Actualizar un autobús existente 
        //10.Eliminar un autobús existente 
        //11.Registrar utilización de cargador por hora del día 
        //12.Actualizar utilización de cargador por hora del día 
        //13.Eliminar utilización de cargador por hora del día 
        //14.Registrar operación por hora del día 
        //15.Actualizar operación por hora del día
        //16.Eliminar operación por hora del día 
        //17.Obtener horas registradas 
        //18.Obtener informe de hora por Id (*)
        //19.Obtener informe de utilización de cargadores por hora
        //20.Obtener informe de utilización de buses por hora 





