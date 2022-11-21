using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DerivedDimensionAttributeValuesEntityVocabulary : SimpleVocabulary
    {
        public DerivedDimensionAttributeValuesEntityVocabulary()
        {
            VocabularyName = "Derived Dimension Attribute Values Entity";
            KeyPrefix = "commonDataModel.deriveddimensionattributevaluesentity";
            KeySeparator = ".";
            Grouping = "/DerivedDimensionAttributeValuesEntity";

            AddGroup("DerivedDimensionAttributeValuesEntity Details", group =>
            {
                DrivingDimensionAttributeName = group.Add(new VocabularyKey(nameof(DrivingDimensionAttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DrivingDimensionAttributeValue = group.Add(new VocabularyKey(nameof(DrivingDimensionAttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeName1 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeName1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValue1 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValue1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeName2 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeName2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValue2 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValue2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeName3 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeName3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValue3 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValue3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeName4 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeName4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValue4 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValue4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeName5 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeName5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValue5 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValue5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeName6 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeName6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValue6 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValue6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeName7 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeName7), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValue7 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValue7), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeName8 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeName8), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValue8 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValue8), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeName9 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeName9), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValue9 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValue9), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeName10 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeName10), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValue10 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValue10), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DrivingDimensionAttribute = group.Add(new VocabularyKey(nameof(DrivingDimensionAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DrivingDimensionAttributeValueRecId = group.Add(new VocabularyKey(nameof(DrivingDimensionAttributeValueRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValueRecId1 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValueRecId1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValueRecId2 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValueRecId2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValueRecId3 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValueRecId3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValueRecId4 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValueRecId4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValueRecId5 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValueRecId5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValueRecId6 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValueRecId6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValueRecId7 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValueRecId7), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValueRecId8 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValueRecId8), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValueRecId9 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValueRecId9), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedDimensionAttributeValueRecId10 = group.Add(new VocabularyKey(nameof(DerivedDimensionAttributeValueRecId10), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey DrivingDimensionAttributeName { get; private set; }
        public VocabularyKey DrivingDimensionAttributeValue { get; private set; }
        public VocabularyKey DerivedDimensionAttributeName1 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValue1 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeName2 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValue2 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeName3 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValue3 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeName4 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValue4 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeName5 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValue5 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeName6 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValue6 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeName7 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValue7 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeName8 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValue8 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeName9 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValue9 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeName10 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValue10 { get; private set; }
        public VocabularyKey DrivingDimensionAttribute { get; private set; }
        public VocabularyKey DrivingDimensionAttributeValueRecId { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValueRecId1 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValueRecId2 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValueRecId3 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValueRecId4 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValueRecId5 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValueRecId6 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValueRecId7 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValueRecId8 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValueRecId9 { get; private set; }
        public VocabularyKey DerivedDimensionAttributeValueRecId10 { get; private set; }
    }
}