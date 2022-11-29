using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DealCustomerVocabulary : SimpleVocabulary
    {
        public DealCustomerVocabulary()
        {
            VocabularyName = "Deal Customer";
            KeyPrefix = "commonDataModel.dealcustomer.automotive";
            KeySeparator = ".";
            Grouping = "/DealCustomer";

            AddGroup("DealCustomer Details for Automotive", group =>
            {
			    Comments = group.Add(new VocabularyKey(nameof(Comments), "Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DealCustomerId = group.Add(new VocabularyKey(nameof(DealCustomerId), "Deal Customer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Role = group.Add(new VocabularyKey(nameof(Role), "Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Comments { get; private set; }
        public VocabularyKey DealCustomerId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Role { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}