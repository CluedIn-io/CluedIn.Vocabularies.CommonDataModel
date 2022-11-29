using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class BookableResourceCharacteristicVocabulary : SimpleVocabulary
    {
        public BookableResourceCharacteristicVocabulary()
        {
            VocabularyName = "Bookable Resource Characteristic";
            KeyPrefix = "commonDataModel.bookableresourcecharacteristic.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/BookableResourceCharacteristic";

            AddGroup("BookableResourceCharacteristic Details for ProjectServiceAutomation", group =>
            {
			    ApprovalStatus = group.Add(new VocabularyKey(nameof(ApprovalStatus), "Approval status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ApprovalStatus { get; private set; }
    }
}