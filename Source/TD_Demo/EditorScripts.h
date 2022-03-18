#pragma once

#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"
#include "EditorScripts.generated.h"

/**
 * 
 */
UCLASS()
class TD_DEMO_API UEditorScripts : public UBlueprintFunctionLibrary
{
  GENERATED_BODY()

public:
  UFUNCTION(BlueprintCallable, Category="Editor")
  static void SetOutlinerFolder(AActor *Actor, const FName Name); 
};
