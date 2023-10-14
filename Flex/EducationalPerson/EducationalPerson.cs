using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flex.EducationalPerson.DateClass;
using Flex.FMS;
namespace Flex.EducationalPerson
{
    public abstract class EducationalPerson : Fms
    { 
        // Attributes
        protected string m_firstName;
    protected string m_lastName;
    protected string m_deptName;
    protected string m_id;
    protected string m_regisDate;
    protected string m_gender;
    protected string m_contactNo;
    protected string m_qualification;
    protected string m_address;

    //
    // Constructors
    public EducationalPerson() : base()
    {
        m_firstName = "";
        m_lastName = "";
        m_deptName = "";
        m_id = "";
        m_regisDate = "";
        m_gender = "";
        m_contactNo = "";
        m_qualification = "";
        m_address = "";
    }
    public EducationalPerson(string firstName, string lastName, string deptName, string id, string regisDate, string gender, string contactNo, string qualification, string address)
    {
        m_firstName = firstName;
        m_lastName = lastName;
        m_deptName = deptName;
        m_id = id;
        m_regisDate = regisDate;
        m_gender = gender;
        m_contactNo = contactNo;
        m_qualification = qualification;
        m_address = address;
    }

    // Destructor
    ~EducationalPerson() { }

    // all the childrens must override it

    public string getFirstName()
    {
            return m_firstName;

    }
    public string getLastName()
        {
            return m_lastName;
        }
    public string getContact()
        {
            return m_contactNo;
        }
    public string getAddress()
        {
            return m_address;
        }
    public abstract bool addToRecord(
      string firstName, string lastName, string deptName, string id, string regisDate,
        string gender, string contactNo, string qualification, string address, string bloodGroup, string feeStatus, string marks,
        string username, string password
    );
    }

}

