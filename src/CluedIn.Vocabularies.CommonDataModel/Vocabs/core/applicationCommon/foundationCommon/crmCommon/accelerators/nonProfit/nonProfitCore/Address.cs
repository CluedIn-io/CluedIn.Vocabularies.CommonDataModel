using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class AddressVocabulary : SimpleVocabulary
    {
        public AddressVocabulary()
        {
            VocabularyName = "Address";
            KeyPrefix = "commonDataModel.address.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/Address";

            AddGroup("Address Details for NonProfitCore", group =>
            {
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsUspsValidated = group.Add(new VocabularyKey(nameof(IsUspsValidated), "USPS Validated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsValidated = group.Add(new VocabularyKey(nameof(IsValidated), "Validated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Region = group.Add(new VocabularyKey(nameof(Region), "Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SeasonalEndDay = group.Add(new VocabularyKey(nameof(SeasonalEndDay), "Seasonal End Day", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SeasonalEndMonth = group.Add(new VocabularyKey(nameof(SeasonalEndMonth), "Seasonal End Month", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SeasonalStartDay = group.Add(new VocabularyKey(nameof(SeasonalStartDay), "Seasonal Start Day", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SeasonalStartMonth = group.Add(new VocabularyKey(nameof(SeasonalStartMonth), "Seasonal Start Month", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telephone1TypeCode = group.Add(new VocabularyKey(nameof(Telephone1TypeCode), "Telephone 1 Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telephone2TypeCode = group.Add(new VocabularyKey(nameof(Telephone2TypeCode), "Telephone 2 Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telephone3TypeCode = group.Add(new VocabularyKey(nameof(Telephone3TypeCode), "Telephone 3 Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey IsUspsValidated { get; private set; }
        public VocabularyKey IsValidated { get; private set; }
        public VocabularyKey Region { get; private set; }
        public VocabularyKey SeasonalEndDay { get; private set; }
        public VocabularyKey SeasonalEndMonth { get; private set; }
        public VocabularyKey SeasonalStartDay { get; private set; }
        public VocabularyKey SeasonalStartMonth { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey Telephone1TypeCode { get; private set; }
        public VocabularyKey Telephone2TypeCode { get; private set; }
        public VocabularyKey Telephone3TypeCode { get; private set; }
    }
}