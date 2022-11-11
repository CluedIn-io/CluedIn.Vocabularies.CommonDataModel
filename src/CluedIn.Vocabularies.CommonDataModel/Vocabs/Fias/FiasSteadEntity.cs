using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiasSteadEntityVocabulary : SimpleVocabulary
    {
        public FiasSteadEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiasSteadEntity";
            KeyPrefix = "commonDataModel.fiassteadentity";
            KeySeparator = ".";
            Grouping = "/FiasSteadEntity";

            AddGroup("Common Data Model FiasSteadEntity Details", group =>
            {
                SteadId = group.Add(new VocabularyKey(nameof(SteadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SteadGuid = group.Add(new VocabularyKey(nameof(SteadGuid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentGuid = group.Add(new VocabularyKey(nameof(ParentGuid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegionCode = group.Add(new VocabularyKey(nameof(RegionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DivType = group.Add(new VocabularyKey(nameof(DivType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Number = group.Add(new VocabularyKey(nameof(Number), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalCode = group.Add(new VocabularyKey(nameof(PostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IFNSFL = group.Add(new VocabularyKey(nameof(IFNSFL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TerrIFNSFL = group.Add(new VocabularyKey(nameof(TerrIFNSFL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OKATO = group.Add(new VocabularyKey(nameof(OKATO), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SteadId { get; private set; }
        public VocabularyKey SteadGuid { get; private set; }
        public VocabularyKey ParentGuid { get; private set; }
        public VocabularyKey RegionCode { get; private set; }
        public VocabularyKey DivType { get; private set; }
        public VocabularyKey Number { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey IFNSFL { get; private set; }
        public VocabularyKey TerrIFNSFL { get; private set; }
        public VocabularyKey OKATO { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey EndDate { get; private set; }


    }
}