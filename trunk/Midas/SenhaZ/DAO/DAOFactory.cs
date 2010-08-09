using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SenhaZ.DAO.SQL;

namespace SenhaZ.DAO
{
    public class DAOFactory
    {
        private static DAOFactory instance = new DAOFactory();
        public static DAOFactory Instance
        {
            get { return DAOFactory.instance; }
            set { DAOFactory.instance = value; }
        }

        public ICategoriaDAO CriarCategoriaDAO()
        {
            return new CategoriaDAO();
        }

    }
}
