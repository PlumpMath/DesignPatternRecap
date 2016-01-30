using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    public abstract class AbstractFactory
    {
        public abstract IDepartment CreatDepartment();

        public abstract IUser CreateUser();

    }

    public class SQLFactory : AbstractFactory
    {
        public override IDepartment CreatDepartment()
        {
            throw new NotImplementedException();
        }

        public override IUser CreateUser()
        {
            throw new NotImplementedException();
        }
    }

    public class OracleFactory : AbstractFactory
    {
        public override IDepartment CreatDepartment()
        {
            throw new NotImplementedException();
        }

        public override IUser CreateUser()
        {
            throw new NotImplementedException();
        }
    }

    public interface IDepartment
    {
        void CreateDepartment();
        void UpdateDepartment();
        void DeleteDepartment();
    }

    public interface IUser
    {
        void CreateUser();

        void DeleteUser();

        void UpdateUser();

    }

    public class SQLUser : IUser
    {
        public void CreateUser()
        {
            throw new NotImplementedException();
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }
    }

    public class OracleUser : IUser
    {
        public void CreateUser()
        {
            throw new NotImplementedException();
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }
    }

    public class SQLDepartment : IDepartment
    {
        public void CreateDepartment()
        {
            throw new NotImplementedException();
        }

        public void DeleteDepartment()
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartment()
        {
            throw new NotImplementedException();
        }
    }

    public class OracleDepartment : IDepartment
    {
        public void CreateDepartment()
        {
            throw new NotImplementedException();
        }

        public void DeleteDepartment()
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartment()
        {
            throw new NotImplementedException();
        }
    }
}
