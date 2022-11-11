using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerRRGCellTable_RUEntityVocabulary : SimpleVocabulary
    {
        public LedgerRRGCellTable_RUEntityVocabulary()
        {
            VocabularyName = "LedgerRRGCellTable_RUEntity";
            KeyPrefix = "commonDataModel.ledgerrrgcelltable_ruentity";
            KeySeparator = ".";
            Grouping = "/LedgerRRGCellTable_RUEntity";

            AddGroup("LedgerRRGCellTable_RUEntity Details", group =>
            {
                Alignment = group.Add(new VocabularyKey(nameof(Alignment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CellCode = group.Add(new VocabularyKey(nameof(CellCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataType = group.Add(new VocabularyKey(nameof(DataType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmptyChar = group.Add(new VocabularyKey(nameof(EmptyChar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsStatic = group.Add(new VocabularyKey(nameof(IsStatic), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerPeriodCode = group.Add(new VocabularyKey(nameof(LedgerPeriodCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Length = group.Add(new VocabularyKey(nameof(Length), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModelNum = group.Add(new VocabularyKey(nameof(ModelNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PointSignNum = group.Add(new VocabularyKey(nameof(PointSignNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RTax25RegisterId = group.Add(new VocabularyKey(nameof(RTax25RegisterId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeByCorrect = group.Add(new VocabularyKey(nameof(TypeByCorrect), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RepCode = group.Add(new VocabularyKey(nameof(RepCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Alignment { get; private set; }
        public VocabularyKey CellCode { get; private set; }
        public VocabularyKey DataType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EmptyChar { get; private set; }
        public VocabularyKey IsStatic { get; private set; }
        public VocabularyKey LedgerPeriodCode { get; private set; }
        public VocabularyKey Length { get; private set; }
        public VocabularyKey ModelNum { get; private set; }
        public VocabularyKey PointSignNum { get; private set; }
        public VocabularyKey RTax25RegisterId { get; private set; }
        public VocabularyKey TypeByCorrect { get; private set; }
        public VocabularyKey RepCode { get; private set; }
        public VocabularyKey LineId { get; private set; }


    }
}