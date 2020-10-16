import QtQuick 2.6
import QtQuick.Controls 2.1
import Features 1.0

ScrollablePage {

    Column {
        spacing: 40
        width: parent.width

        Label {
            width: parent.width
            wrapMode: Label.Wrap
            horizontalAlignment: Qt.AlignHCenter
            text: "Tasks can be invoked and awaited from Qml. Continuations happen on Qt's main thread."
        }

        Button {
            text: 'Call async method'
            onClicked: {
                message.text = 'Processing...'
                var task = model.runAsyncTask('Hello from qml: ' + new Date())
                Net.await(task, function(result) {
                    message.text = result
                })
            }
        }
        
        Text {
            id: message
        }
        
        AsyncAwaitModel {
            id: model
        }
    }
}
