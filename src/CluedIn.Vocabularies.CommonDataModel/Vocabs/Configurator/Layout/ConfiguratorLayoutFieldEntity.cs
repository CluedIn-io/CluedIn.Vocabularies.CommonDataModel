using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConfiguratorLayoutFieldEntityVocabulary : SimpleVocabulary
    {
        public ConfiguratorLayoutFieldEntityVocabulary()
        {
            VocabularyName = "Common Data Model ConfiguratorLayoutFieldEntity";
            KeyPrefix = "commonDataModel.configuratorlayoutfieldentity";
            KeySeparator = ".";
            Grouping = "/ConfiguratorLayoutFieldEntity";

            AddGroup("Common Data Model ConfiguratorLayoutFieldEntity Details", group =>
            {
                BatchId = group.Add(new VocabularyKey(nameof(BatchId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comments = group.Add(new VocabularyKey(nameof(Comments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArrayIndex = group.Add(new VocabularyKey(nameof(ArrayIndex), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Fill = group.Add(new VocabularyKey(nameof(Fill), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldNumber = group.Add(new VocabularyKey(nameof(FieldNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Format = group.Add(new VocabularyKey(nameof(Format), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Justification = group.Add(new VocabularyKey(nameof(Justification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LayoutGroupId = group.Add(new VocabularyKey(nameof(LayoutGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MethodName = group.Add(new VocabularyKey(nameof(MethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeOfMethod = group.Add(new VocabularyKey(nameof(TypeOfMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartPosition = group.Add(new VocabularyKey(nameof(StartPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldSize = group.Add(new VocabularyKey(nameof(FieldSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndPosition = group.Add(new VocabularyKey(nameof(EndPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SummationType = group.Add(new VocabularyKey(nameof(SummationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableName = group.Add(new VocabularyKey(nameof(TableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TruncateField = group.Add(new VocabularyKey(nameof(TruncateField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Content = group.Add(new VocabularyKey(nameof(Content), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BatchId { get; private set; }
        public VocabularyKey Comments { get; private set; }
        public VocabularyKey ArrayIndex { get; private set; }
        public VocabularyKey Fill { get; private set; }
        public VocabularyKey FieldName { get; private set; }
        public VocabularyKey FieldNumber { get; private set; }
        public VocabularyKey Format { get; private set; }
        public VocabularyKey Justification { get; private set; }
        public VocabularyKey LayoutGroupId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey MethodName { get; private set; }
        public VocabularyKey TypeOfMethod { get; private set; }
        public VocabularyKey StartPosition { get; private set; }
        public VocabularyKey FieldSize { get; private set; }
        public VocabularyKey EndPosition { get; private set; }
        public VocabularyKey SummationType { get; private set; }
        public VocabularyKey TableName { get; private set; }
        public VocabularyKey TruncateField { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey Content { get; private set; }


    }
}