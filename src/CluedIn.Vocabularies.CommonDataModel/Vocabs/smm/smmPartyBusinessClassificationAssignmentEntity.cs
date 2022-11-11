using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmPartyBusinessClassificationAssignmentEntityVocabulary : SimpleVocabulary
    {
        public smmPartyBusinessClassificationAssignmentEntityVocabulary()
        {
            VocabularyName = "smmPartyBusinessClassificationAssignmentEntity";
            KeyPrefix = "commonDataModel.smmpartybusinessclassificationassignmententity";
            KeySeparator = ".";
            Grouping = "/smmPartyBusinessClassificationAssignmentEntity";

            AddGroup("smmPartyBusinessClassificationAssignmentEntity Details", group =>
            {
                BusinessClassificationCode = group.Add(new VocabularyKey(nameof(BusinessClassificationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyRecId = group.Add(new VocabularyKey(nameof(PartyRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MergedPartyRecId = group.Add(new VocabularyKey(nameof(MergedPartyRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MergedPartyNumber = group.Add(new VocabularyKey(nameof(MergedPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BusinessClassificationCode { get; private set; }
        public VocabularyKey PartyRecId { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey MergedPartyRecId { get; private set; }
        public VocabularyKey MergedPartyNumber { get; private set; }


    }
}