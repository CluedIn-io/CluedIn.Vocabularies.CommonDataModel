using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductSpecificUnitOfMeasureConversionEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductSpecificUnitOfMeasureConversionEntityVocabulary()
        {
            VocabularyName = "EcoResProductSpecificUnitOfMeasureConversionEntity";
            KeyPrefix = "commonDataModel.ecoresproductspecificunitofmeasureconversionentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductSpecificUnitOfMeasureConversionEntity";

            AddGroup("EcoResProductSpecificUnitOfMeasureConversionEntity Details", group =>
            {
                Denominator = group.Add(new VocabularyKey(nameof(Denominator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Factor = group.Add(new VocabularyKey(nameof(Factor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromUnitOfMeasureRecId = group.Add(new VocabularyKey(nameof(FromUnitOfMeasureRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InnerOffset = group.Add(new VocabularyKey(nameof(InnerOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Numerator = group.Add(new VocabularyKey(nameof(Numerator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OuterOffset = group.Add(new VocabularyKey(nameof(OuterOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductRecId = group.Add(new VocabularyKey(nameof(ProductRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rounding = group.Add(new VocabularyKey(nameof(Rounding), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToUnitOfMeasureRecId = group.Add(new VocabularyKey(nameof(ToUnitOfMeasureRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromUnitSymbol = group.Add(new VocabularyKey(nameof(FromUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToUnitSymbol = group.Add(new VocabularyKey(nameof(ToUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Denominator { get; private set; }
        public VocabularyKey Factor { get; private set; }
        public VocabularyKey FromUnitOfMeasureRecId { get; private set; }
        public VocabularyKey InnerOffset { get; private set; }
        public VocabularyKey Numerator { get; private set; }
        public VocabularyKey OuterOffset { get; private set; }
        public VocabularyKey ProductRecId { get; private set; }
        public VocabularyKey Rounding { get; private set; }
        public VocabularyKey ToUnitOfMeasureRecId { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey FromUnitSymbol { get; private set; }
        public VocabularyKey ToUnitSymbol { get; private set; }


    }
}