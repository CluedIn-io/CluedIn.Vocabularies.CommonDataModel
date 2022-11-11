using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailEcoResCategoryEntityVocabulary : SimpleVocabulary
    {
        public RetailEcoResCategoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailEcoResCategoryEntity";
            KeyPrefix = "commonDataModel.retailecorescategoryentity";
            KeySeparator = ".";
            Grouping = "/RetailEcoResCategoryEntity";

            AddGroup("Common Data Model RetailEcoResCategoryEntity Details", group =>
            {
                CategoryHierarchy = group.Add(new VocabularyKey(nameof(CategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChangeStatus = group.Add(new VocabularyKey(nameof(ChangeStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultProjectGlobalCategory = group.Add(new VocabularyKey(nameof(DefaultProjectGlobalCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultThreshold_PSN = group.Add(new VocabularyKey(nameof(DefaultThreshold_PSN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InstanceRelationType = group.Add(new VocabularyKey(nameof(InstanceRelationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActive = group.Add(new VocabularyKey(nameof(IsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCategoryAttributesInherited = group.Add(new VocabularyKey(nameof(IsCategoryAttributesInherited), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTangible = group.Add(new VocabularyKey(nameof(IsTangible), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Level = group.Add(new VocabularyKey(nameof(Level), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NestedSetLeft = group.Add(new VocabularyKey(nameof(NestedSetLeft), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NestedSetRight = group.Add(new VocabularyKey(nameof(NestedSetRight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentCategory = group.Add(new VocabularyKey(nameof(ParentCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PKWiUCode = group.Add(new VocabularyKey(nameof(PKWiUCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SharedCategory_CategoryId = group.Add(new VocabularyKey(nameof(SharedCategory_CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EcoResCategoryHierarchy_Name = group.Add(new VocabularyKey(nameof(EcoResCategoryHierarchy_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EcoResCategory1_CategoryHierarchy = group.Add(new VocabularyKey(nameof(EcoResCategory1_CategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EcoResCategory1_Name = group.Add(new VocabularyKey(nameof(EcoResCategory1_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EcoResCategoryHierarchy1_Name = group.Add(new VocabularyKey(nameof(EcoResCategoryHierarchy1_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AxRecId = group.Add(new VocabularyKey(nameof(AxRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CategoryHierarchy { get; private set; }
        public VocabularyKey ChangeStatus { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey DefaultProjectGlobalCategory { get; private set; }
        public VocabularyKey DefaultThreshold_PSN { get; private set; }
        public VocabularyKey InstanceRelationType { get; private set; }
        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey IsCategoryAttributesInherited { get; private set; }
        public VocabularyKey IsTangible { get; private set; }
        public VocabularyKey Level { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NestedSetLeft { get; private set; }
        public VocabularyKey NestedSetRight { get; private set; }
        public VocabularyKey ParentCategory { get; private set; }
        public VocabularyKey PKWiUCode { get; private set; }
        public VocabularyKey SharedCategory_CategoryId { get; private set; }
        public VocabularyKey EcoResCategoryHierarchy_Name { get; private set; }
        public VocabularyKey EcoResCategory1_CategoryHierarchy { get; private set; }
        public VocabularyKey EcoResCategory1_Name { get; private set; }
        public VocabularyKey EcoResCategoryHierarchy1_Name { get; private set; }
        public VocabularyKey AxRecId { get; private set; }


    }
}