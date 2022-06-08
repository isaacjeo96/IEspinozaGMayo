using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Materia
    {
        public static ML.Result Add(ML.Materia materia)//Stored Procedure agregar datos Entity framework
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.IEspinozaGMayoEntities context = new DL.IEspinozaGMayoEntities())
                {
                    var restulQuery = context.MateriaAdd(materia.Nombre, materia.Costo, materia.Creditos, materia.Descripcion);


                    if (restulQuery >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se insertó el registro";
                    }

                    result.Correct = true;

                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result Update(ML.Materia materia)//stored procedure actualizar datos con Entety Framework
        {
            ML.Result result = new ML.Result();
            try
            {

                using (DL.IEspinozaGMayoEntities context = new DL.IEspinozaGMayoEntities())
                {
                    var updateResult = context.MateriaUpdate(materia.IdMateria, materia.Nombre, materia.Costo,materia.Creditos,materia.Descripcion);
                    if (updateResult >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se actualizó el status de la credencial";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        public static ML.Result Delete(int IdMateria)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.IEspinozaGMayoEntities context = new DL.IEspinozaGMayoEntities())
                {

                    var query = context.MateriaDelete(IdMateria);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se eliminó el registro";
                    }

                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }//stored procedure borrar registro con EntityFramework

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.IEspinozaGMayoEntities context = new DL.IEspinozaGMayoEntities())
                {

                    var materias = context.MateriaGetAll().ToList();

                    result.Objects = new List<object>();

                    if (materias != null)
                    {
                        foreach (var obj in materias)
                        {
                            ML.Materia materia = new ML.Materia();

                            materia.IdMateria = obj.IdMateria;
                            materia.Nombre = obj.Nombre;
                            materia.Costo = obj.Costo.Value;
                            materia.Creditos = obj.Creditos.Value;
                            materia.Descripcion = obj.Descripcion;

                            result.Objects.Add(materia);
                        }

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontraron registros.";
                    }
                }
            }
            catch (Exception ex)
            {

                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }

            return result;
        }//termina getallEF

        public static ML.Result GetById(int IdMateria)
        {
         
           ML.Result result = new ML.Result();

            try
            {
                using (DL.IEspinozaGMayoEntities context = new DL.IEspinozaGMayoEntities())
                {
                    var obj = context.MateriaGetById(IdMateria).FirstOrDefault();

                    result.Objects = new List<object>();

                    if (obj != null)
                    {
                        ML.Materia materia = new ML.Materia();
                        materia.IdMateria = obj.IdMateria;
                        materia.Nombre = obj.Nombre;
                        materia.Costo = obj.Costo.Value;
                        materia.Creditos = obj.Creditos.Value;
                        materia.Descripcion = obj.Descripcion;

                        result.Object = materia;

                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontraron registros.";
                    }
                }
            }
            catch (Exception ex)
            {

                result.Correct = false;
                result.ErrorMessage = ex.Message;

            }

            return result;
        }
    }
}
