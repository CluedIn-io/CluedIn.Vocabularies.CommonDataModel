using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class OwnerVocabulary : SimpleVocabulary
    {
        public OwnerVocabulary()
        {
            VocabularyName = "Owner";
            KeyPrefix = "commonDataModel.owner";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Owner;

            AddGroup("Owner Details for ApplicationCommon", group =>
            {
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwnerId = group.Add(new VocabularyKey(nameof(OwnerId), "Owner", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Owner Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    YomiName = group.Add(new VocabularyKey(nameof(YomiName), "Yomi Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey OwnerId { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey YomiName { get; private set; }
    }
}