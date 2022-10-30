using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common.Cache;


namespace Domain
{ 
    public class UserModel
    {
        UserDao userDao = new UserDao();

        private int id;
        private string nombre;
        private string usuario;
        private string contraseña;

        public UserModel(int id, string nombre, string usuario, string contraseña)
        {
            this.id = id;
            this.nombre = nombre;
            this.usuario = usuario;
            this.contraseña = contraseña;
        }

        public UserModel()
        {

        }

        public string editarusuario()
        {

            try
            {
                userDao.EditarPefil(id, nombre, usuario, contraseña);
                LoginUser(usuario, nombre);
                return "perfil actualisado correctamente";
            }
            catch (Exception ex)
            {
                return "error";
            }
        }
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }

        public bool RegisterUser(string name, string user, string pass)
        {
            return userDao.Register(name, user, pass);
        }
    }
}
