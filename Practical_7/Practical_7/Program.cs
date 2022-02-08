using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7
{
    public class Employee
    {
        public int EmployeeID;
        public string EmployeeName;
    }

    #region Single Responsibility Principle Example
    // Single Responsibility Principle Example
    public class SingleResponsibilityPrinciple
    {
        public bool AddNewEmployee()
        {
            return true;
        }
    }
    // Single Responsibility Principle Example

    #endregion Single Responsibility Principle Example

    #region Open Closed Principle Example

    // Open Closed Principle Example
    public class OpenClosedPrinciple
    {
        public string ReportType;
        public virtual void GenerateReport()
        {
            Console.WriteLine("Report Details");
        }
    }

    public class StockInformationReport : OpenClosedPrinciple
    {
        public override void GenerateReport()
        {
            Console.WriteLine("Report Details");
        }
    }

    public class ProductInformationReport : OpenClosedPrinciple
    {
        public override void GenerateReport()
        {
            Console.WriteLine("Report Details");
        }
    }
    // Open Closed Principle Example

    #endregion Open Closed Principle Example

    #region Lisko Substitution Principle Example

    // Lisko Substitution Principle Example

    public interface IStockInformation
    {
        string GetStockinformationDetails();
    }

    public class IStockInformationReport : IStockInformation
    {
        public string GetStockinformationDetails()
        {
            throw new NotImplementedException();
        }
    }

    // Lisko Substitution Principle Example

    #endregion Lisko Substitution Principle Example

    #region Interface Segregation Principle
    // Interface Segregation Principle
    public interface IReport
    {
        bool AddReportDetails();
    }
    public interface IReadReport
    {
        bool ReadReportDetails();
    }

    // Interface Segregation Principle
    #endregion Interface Segregation Principle

    #region Dependency inversion Principle
    // Dependency inversion Principle

    public interface MessageReport
    {
        void SendMessage();
    }

    public interface EmailReport : MessageReport
    {
        void SendEmail();
    }
    public interface SMSReport : MessageReport
    {
        void SendSMS();
    }

    // Dependency inversion Principle
    #endregion Dependency inversion Principle

    #region Main Class

    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    #endregion Main Class
}
