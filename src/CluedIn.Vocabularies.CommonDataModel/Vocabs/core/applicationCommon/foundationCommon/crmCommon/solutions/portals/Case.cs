using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class CaseVocabulary : SimpleVocabulary
    {
        public CaseVocabulary()
        {
            VocabularyName = "Case";
            KeyPrefix = "commonDataModel.case.portals";
            KeySeparator = ".";
            Grouping = "/Case";

            AddGroup("Case Details for Portals", group =>
            {
			    AdxCreatedByIPAddress = group.Add(new VocabularyKey(nameof(AdxCreatedByIPAddress), "Created By IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxCreatedByUsername = group.Add(new VocabularyKey(nameof(AdxCreatedByUsername), "Created By Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByIPAddress = group.Add(new VocabularyKey(nameof(AdxModifiedByIPAddress), "Modified By IP Address", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdxModifiedByUsername = group.Add(new VocabularyKey(nameof(AdxModifiedByUsername), "Modified By Username", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PublishToWeb = group.Add(new VocabularyKey(nameof(PublishToWeb), "Publish to Web", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Resolution = group.Add(new VocabularyKey(nameof(Resolution), "Resolution", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResolutionDate = group.Add(new VocabularyKey(nameof(ResolutionDate), "Resolution Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StepsToReproduce = group.Add(new VocabularyKey(nameof(StepsToReproduce), "Steps to Reproduce", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AdxCreatedByIPAddress { get; private set; }
        public VocabularyKey AdxCreatedByUsername { get; private set; }
        public VocabularyKey AdxModifiedByIPAddress { get; private set; }
        public VocabularyKey AdxModifiedByUsername { get; private set; }
        public VocabularyKey PublishToWeb { get; private set; }
        public VocabularyKey Resolution { get; private set; }
        public VocabularyKey ResolutionDate { get; private set; }
        public VocabularyKey StepsToReproduce { get; private set; }
    }
}