using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Banking
{
    public class BranchVocabulary : SimpleVocabulary
    {
        public BranchVocabulary()
        {
            VocabularyName = "Branch";
            KeyPrefix = "commonDataModel.branch.banking";
            KeySeparator = ".";
            Grouping = "/Branch";

            AddGroup("Branch Details for Banking", group =>
            {
			    AddressLine1 = group.Add(new VocabularyKey(nameof(AddressLine1), "Address Line 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLine2 = group.Add(new VocabularyKey(nameof(AddressLine2), "Address Line 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AddressLine3 = group.Add(new VocabularyKey(nameof(AddressLine3), "Address Line 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BranchCode = group.Add(new VocabularyKey(nameof(BranchCode), "Branch Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BranchId = group.Add(new VocabularyKey(nameof(BranchId), "Branch", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BranchName = group.Add(new VocabularyKey(nameof(BranchName), "Branch Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Country = group.Add(new VocabularyKey(nameof(Country), "Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    State = group.Add(new VocabularyKey(nameof(State), "State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TelephoneNo = group.Add(new VocabularyKey(nameof(TelephoneNo), "Telephone No.", VocabularyKeyDataType.PhoneNumber, VocabularyKeyVisibility.Visible)); 
			    ZipCodes = group.Add(new VocabularyKey(nameof(ZipCodes), "Zip Codes", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AddressLine1 { get; private set; }
        public VocabularyKey AddressLine2 { get; private set; }
        public VocabularyKey AddressLine3 { get; private set; }
        public VocabularyKey BranchCode { get; private set; }
        public VocabularyKey BranchId { get; private set; }
        public VocabularyKey BranchName { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey TelephoneNo { get; private set; }
        public VocabularyKey ZipCodes { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}