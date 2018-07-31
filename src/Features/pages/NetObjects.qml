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
            text: "Any .NET reference can be used in Qml, even ones not explicitly registered. Extensive unit tests ensure proper garbage collection."
        }

        Button {
            text: 'Play with .NET object'
            onClicked: {
                var netObject = model.getNetObject()
                netObject.updateProperty('Hello! ' + new Date())
                message.text = netObject.property
            }
        }
        
        Text {
            id: message
        }
        
        NetObjectsModel {
            id: model
        }
    }
}
