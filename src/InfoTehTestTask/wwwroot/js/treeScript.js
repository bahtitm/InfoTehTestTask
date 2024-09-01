var data=[];

var url="https://localhost:7083/api/Folders/WithFile"

httpGetAsync(url,caltr);

const container = document.getElementById('tree-container');
const treeData = buildTree(data);
container.appendChild(createTreeElement(treeData));





function buildTree(data) {
    const nodeMap = new Map();
    const rootNodes = [];

    // Create a map of all nodes
    data.forEach(node => {
        nodeMap.set(node.id, { ...node, children: [] });
    });

    // Populate children
    data.forEach(node => {
        const currentNode = nodeMap.get(node.id);
        if (node.parentId === 0) {
            rootNodes.push(currentNode);
        } else {
            const parentNode = nodeMap.get(node.parentId);
            if (parentNode) {
                parentNode.children.push(currentNode);
            }
        }
    });

    return rootNodes;
}

function createTreeElement(nodes) {
    const ul = document.createElement('ul');
    nodes.forEach(node => {
        const li = document.createElement('li');
        const icon = document.createElement('span');
        icon.classList.add('icon');
        
        const textSpan = document.createElement('span');       
        textSpan.setAttribute("parentId",node.parentId);
        textSpan.setAttribute("id",node.id);
        textSpan.setAttribute("isFile",node.isFile);
        textSpan.setAttribute("fileId",node.fileId)
        textSpan.textContent = node.name;

        textSpan.addEventListener('click', function(e) {
            e.stopPropagation();
            document.querySelectorAll('.selected').forEach(el => el.classList.remove('selected'));
            this.classList.add('selected');
           
            console.log('Selected node:', e);        
        });

        li.appendChild(icon);
        li.appendChild(textSpan);

        if (node.children.length > 0) {
            li.classList.add('collapsible');
            const nestedUl = createTreeElement(node.children);
            nestedUl.classList.add('nested');
            li.appendChild(nestedUl);

            icon.addEventListener('click', function(e) {
                e.stopPropagation();
                li.classList.toggle('open');
                nestedUl.classList.toggle('show');
            });
        }

        ul.appendChild(li);
    });

    return ul;
}




  function httpGetAsync(theUrl, callback)
  {
      var xmlHttp = new XMLHttpRequest();
      xmlHttp.onreadystatechange = function() { 
          if (xmlHttp.readyState == 4 && xmlHttp.status == 200)
              callback(xmlHttp.responseText);
      }
      xmlHttp.open("GET", theUrl, false); // true for asynchronous 
      xmlHttp.send(null);
  }
  function caltr(data1){  
    this.data = JSON.parse(data1);    
  }