using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCDSTransactionRelationshipImportEntityVocabulary : SimpleVocabulary
    {
        public ProjCDSTransactionRelationshipImportEntityVocabulary()
        {
            VocabularyName = "ProjCDSTransactionRelationshipImportEntity";
            KeyPrefix = "commonDataModel.projcdstransactionrelationshipimportentity";
            KeySeparator = ".";
            Grouping = "/ProjCDSTransactionRelationshipImportEntity";

            AddGroup("ProjCDSTransactionRelationshipImportEntity Details", group =>
            {
                ConnectionId = group.Add(new VocabularyKey(nameof(ConnectionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transaction1Id = group.Add(new VocabularyKey(nameof(Transaction1Id), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transaction1Role = group.Add(new VocabularyKey(nameof(Transaction1Role), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transaction1Type = group.Add(new VocabularyKey(nameof(Transaction1Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transaction2Id = group.Add(new VocabularyKey(nameof(Transaction2Id), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transaction2Role = group.Add(new VocabularyKey(nameof(Transaction2Role), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transaction2Type = group.Add(new VocabularyKey(nameof(Transaction2Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ConnectionId { get; private set; }
        public VocabularyKey Transaction1Id { get; private set; }
        public VocabularyKey Transaction1Role { get; private set; }
        public VocabularyKey Transaction1Type { get; private set; }
        public VocabularyKey Transaction2Id { get; private set; }
        public VocabularyKey Transaction2Role { get; private set; }
        public VocabularyKey Transaction2Type { get; private set; }


    }
}