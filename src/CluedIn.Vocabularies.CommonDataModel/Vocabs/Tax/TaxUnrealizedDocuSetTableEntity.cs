using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxUnrealizedDocuSetTableEntityVocabulary : SimpleVocabulary
    {
        public TaxUnrealizedDocuSetTableEntityVocabulary()
        {
            VocabularyName = "TaxUnrealizedDocuSetTableEntity";
            KeyPrefix = "commonDataModel.taxunrealizeddocusettableentity";
            KeySeparator = ".";
            Grouping = "/TaxUnrealizedDocuSetTableEntity";

            AddGroup("TaxUnrealizedDocuSetTableEntity Details", group =>
            {
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiscText = group.Add(new VocabularyKey(nameof(MiscText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProdType = group.Add(new VocabularyKey(nameof(ProdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintHeader = group.Add(new VocabularyKey(nameof(PrintHeader), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey MiscText { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProdType { get; private set; }
        public VocabularyKey PrintHeader { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LineId { get; private set; }


    }
}