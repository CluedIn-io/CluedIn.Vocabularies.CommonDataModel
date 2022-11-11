using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsAddressFormatLinesEntityVocabulary : SimpleVocabulary
    {
        public LogisticsAddressFormatLinesEntityVocabulary()
        {
            VocabularyName = "LogisticsAddressFormatLinesEntity";
            KeyPrefix = "commonDataModel.logisticsaddressformatlinesentity";
            KeySeparator = ".";
            Grouping = "/LogisticsAddressFormatLinesEntity";

            AddGroup("LogisticsAddressFormatLinesEntity Details", group =>
            {
                AddressFormat = group.Add(new VocabularyKey(nameof(AddressFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressApplicationObject = group.Add(new VocabularyKey(nameof(AddressApplicationObject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Separator = group.Add(new VocabularyKey(nameof(Separator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NewLine = group.Add(new VocabularyKey(nameof(NewLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataEntryOnly = group.Add(new VocabularyKey(nameof(DataEntryOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NotActive = group.Add(new VocabularyKey(nameof(NotActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Expand = group.Add(new VocabularyKey(nameof(Expand), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Special = group.Add(new VocabularyKey(nameof(Special), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrigSeparator = group.Add(new VocabularyKey(nameof(OrigSeparator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AddressFormat { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey AddressApplicationObject { get; private set; }
        public VocabularyKey Separator { get; private set; }
        public VocabularyKey NewLine { get; private set; }
        public VocabularyKey DataEntryOnly { get; private set; }
        public VocabularyKey NotActive { get; private set; }
        public VocabularyKey Expand { get; private set; }
        public VocabularyKey Special { get; private set; }
        public VocabularyKey OrigSeparator { get; private set; }


    }
}