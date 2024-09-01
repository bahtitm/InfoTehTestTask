let observer = new MutationObserver((mutations) => {
    for (let mutation of mutations) {
      if (mutation.type === "childList") {
          SetListenerOnForm();
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