using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class OwnerVocabulary : SimpleVocabulary
    {
        public OwnerVocabulary()
        {
            VocabularyName = "Owner";
            KeyPrefix = "commonDataModel.owner.applicationcommon";
            KeySeparator = ".";
            Grouping = "/Owner";

            AddGroup("Owner Details for ApplicationCommon", group =>
            {
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwnerId = group.Add(new VocabularyKey(nameof(OwnerId), "Owner", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Owner Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    YomiName = group.Add(new VocabularyKey(nameof(YomiName), "Yomi Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey OwnerId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey YomiName { get; private set; }
    }
}