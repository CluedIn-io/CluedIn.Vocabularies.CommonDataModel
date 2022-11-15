using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMRegulationEntityVocabulary : SimpleVocabulary
    {
        public HMIMRegulationEntityVocabulary()
        {
            VocabularyName = "HMIM Regulation Entity";
            KeyPrefix = "commonDataModel.hmimregulationentity";
            KeySeparator = ".";
            Grouping = "/HMIMRegulationEntity";

            AddGroup("HMIMRegulationEntity Details", group =>
            {
                RegCode = group.Add(new VocabularyKey(nameof(RegCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintAfter = group.Add(new VocabularyKey(nameof(PrintAfter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintBefore = group.Add(new VocabularyKey(nameof(PrintBefore), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintField = group.Add(new VocabularyKey(nameof(PrintField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintWithPrevious = group.Add(new VocabularyKey(nameof(PrintWithPrevious), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintCode = group.Add(new VocabularyKey(nameof(PrintCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RegCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PrintAfter { get; private set; }
        public VocabularyKey PrintBefore { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey PrintField { get; private set; }
        public VocabularyKey PrintWithPrevious { get; private set; }
        public VocabularyKey PrintCode { get; private set; }
    }
}