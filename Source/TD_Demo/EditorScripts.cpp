#include "EditorScripts.h"

void UEditorScripts::SetOutlinerFolder(AActor* Actor, const FName Name)
{
#if WITH_EDITOR
  Actor->SetFolderPath(Name);
#endif
}
