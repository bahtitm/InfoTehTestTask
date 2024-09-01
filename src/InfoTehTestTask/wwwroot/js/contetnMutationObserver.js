let observer = new MutationObserver((mutations) => {
    for (let mutation of mutations) {
      if (mutation.type === "childList") {
          SetListenerOnForm();

          for(let node of mutation.addedNodes) {
             // отслеживаем только узлы-элементы, другие (текстовые) пропускаем
             if (!(node instanceof HTMLElement)) continue;
      
             // проверить, не является ли вставленный элемент примером кода
             if (node.matches('form#CreateFile')) {
                FileExtensionsGetter();
             }
          }
           
          
        
          
        console.log("A child node has been added or removed.");
      } else if (mutation.type === "characterData") {
        console.log("Text content was changed.");
      }
      // проверим новые узлы, есть ли что-то, что надо подсветить?

      
    }
  });

  let demoElem = document.getElementById("content");
  if(demoElem)
  {

      observer.observe(demoElem, { childList: true, subtree: true });

  }