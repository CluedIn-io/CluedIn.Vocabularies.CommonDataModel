using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductLifecycleStateEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductLifecycleStateEntityVocabulary()
        {
            VocabularyName = "EcoResProductLifecycleStateEntity";
            KeyPrefix = "commonDataModel.ecoresproductlifecyclestateentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductLifecycleStateEntity";

            AddGroup("EcoResProductLifecycleStateEntity Details", group =>
            {
                LifecycleStateId = group.Add(new VocabularyKey(nameof(LifecycleStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LifecycleStateDescription = group.Add(new VocabularyKey(nameof(LifecycleStateDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActiveForPlanning = group.Add(new VocabularyKey(nameof(IsActiveForPlanning), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultOnProductRelease = group.Add(new VocabularyKey(nameof(IsDefaultOnProductRelease), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LifecycleStateId { get; private set; }
        public VocabularyKey LifecycleStateDescription { get; private set; }
        public VocabularyKey IsActiveForPlanning { get; private set; }
        public VocabularyKey IsDefaultOnProductRelease { get; private set; }


    }
}