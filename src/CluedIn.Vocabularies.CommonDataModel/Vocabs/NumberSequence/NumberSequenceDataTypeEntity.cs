using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class NumberSequenceDataTypeEntityVocabulary : SimpleVocabulary
    {
        public NumberSequenceDataTypeEntityVocabulary()
        {
            VocabularyName = "Number Sequence Data Type Entity";
            KeyPrefix = "commonDataModel.numbersequencedatatypeentity";
            KeySeparator = ".";
            Grouping = "/NumberSequenceDataTypeEntity";

            AddGroup("NumberSequenceDataTypeEntity Details", group =>
            {
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataType = group.Add(new VocabularyKey(nameof(DataType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeID = group.Add(new VocabularyKey(nameof(TypeID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Group = group.Add(new VocabularyKey(nameof(Group), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reference = group.Add(new VocabularyKey(nameof(Reference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScopeType = group.Add(new VocabularyKey(nameof(ScopeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Sorting = group.Add(new VocabularyKey(nameof(Sorting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToALowerNumber = group.Add(new VocabularyKey(nameof(ToALowerNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToAHigherNumber = group.Add(new VocabularyKey(nameof(ToAHigherNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Continuous = group.Add(new VocabularyKey(nameof(Continuous), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityOfNumbers = group.Add(new VocabularyKey(nameof(QuantityOfNumbers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Highest = group.Add(new VocabularyKey(nameof(Highest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Lowest = group.Add(new VocabularyKey(nameof(Lowest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Manual = group.Add(new VocabularyKey(nameof(Manual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceArea = group.Add(new VocabularyKey(nameof(NumberSequenceArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartitionKey = group.Add(new VocabularyKey(nameof(PartitionKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ID { get; private set; }
        public VocabularyKey DataType { get; private set; }
        public VocabularyKey TypeID { get; private set; }
        public VocabularyKey Group { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey ScopeType { get; private set; }
        public VocabularyKey Sorting { get; private set; }
        public VocabularyKey ToALowerNumber { get; private set; }
        public VocabularyKey ToAHigherNumber { get; private set; }
        public VocabularyKey Continuous { get; private set; }
        public VocabularyKey QuantityOfNumbers { get; private set; }
        public VocabularyKey Highest { get; private set; }
        public VocabularyKey Lowest { get; private set; }
        public VocabularyKey Manual { get; private set; }
        public VocabularyKey NumberSequenceArea { get; private set; }
        public VocabularyKey PartitionKey { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}