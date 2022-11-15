using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeOMDepartmentEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeOMDepartmentEntityVocabulary()
        {
            VocabularyName = "Dim Attribute OM Department Entity";
            KeyPrefix = "commonDataModel.dimattributeomdepartmententity";
            KeySeparator = ".";
            Grouping = "/DimAttributeOMDepartmentEntity";

            AddGroup("DimAttributeOMDepartmentEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}