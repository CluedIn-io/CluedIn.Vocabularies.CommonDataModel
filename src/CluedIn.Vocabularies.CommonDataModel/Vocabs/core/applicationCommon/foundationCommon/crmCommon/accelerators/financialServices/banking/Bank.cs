using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Banking
{
    public class BankVocabulary : SimpleVocabulary
    {
        public BankVocabulary()
        {
            VocabularyName = "Bank";
            KeyPrefix = "commonDataModel.bank.banking";
            KeySeparator = ".";
            Grouping = "/Bank";

            AddGroup("Bank Details for Banking", group =>
            {
			    AddressLine1 = group.Add(new VocabularyKey(nameof(AddressLine1), "Address Line 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLine2 = group.Add(new VocabularyKey(nameof(AddressLine2), "Address Line 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLine3 = group.Add(new VocabularyKey(nameof(AddressLine3), "Address Line 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BankCode = group.Add(new VocabularyKey(nameof(BankCode), "Bank Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BankId = group.Add(new VocabularyKey(nameof(BankId), "Bank", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BankName = group.Add(new VocabularyKey(nameof(BankName), "Bank Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Country = group.Add(new VocabularyKey(nameof(Country), "Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    State = group.Add(new VocabularyKey(nameof(State), "State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TelelphoneNo = group.Add(new VocabularyKey(nameof(TelelphoneNo), "Telelphone No.", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    ZipCodes = group.Add(new VocabularyKey(nameof(ZipCodes), "Zip Codes", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AddressLine1 { get; private set; }
        public VocabularyKey AddressLine2 { get; private set; }
        public VocabularyKey AddressLine3 { get; private set; }
        public VocabularyKey BankCode { get; private set; }
        public VocabularyKey BankId { get; private set; }
        public VocabularyKey BankName { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey TelelphoneNo { get; private set; }
        public VocabularyKey ZipCodes { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}