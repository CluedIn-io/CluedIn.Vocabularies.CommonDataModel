using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FIASOperationStatusesEntityVocabulary : SimpleVocabulary
    {
        public FIASOperationStatusesEntityVocabulary()
        {
            VocabularyName = "FIASOperationStatusesEntity";
            KeyPrefix = "commonDataModel.fiasoperationstatusesentity";
            KeySeparator = ".";
            Grouping = "/FIASOperationStatusesEntity";

            AddGroup("FIASOperationStatusesEntity Details", group =>
            {
                FiasOperationType_RU = group.Add(new VocabularyKey(nameof(FiasOperationType_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationDescription = group.Add(new VocabularyKey(nameof(OperationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationStatus = group.Add(new VocabularyKey(nameof(OperationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FiasOperationType_RU { get; private set; }
        public VocabularyKey OperationDescription { get; private set; }
        public VocabularyKey OperationStatus { get; private set; }


    }
}