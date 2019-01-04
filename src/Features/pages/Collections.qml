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
            text: "A List<Contact> is bound to a Repeater."
        }

        Row {
            TextField {
                id: name
                placeholderText: "Name"
            }
        }
        
        Row {
            TextField {
                id: phoneNumber
                placeholderText: "Phone number"
            }
        }
        
        Button {
            text: "Add contact"
            onClicked: {
                if(collectionsModel.addContact(name.text, phoneNumber.text)) {
                    repeater.model = Net.toListModel(collectionsModel.contacts)
                    name.text = null
                    phoneNumber.text = null
                }
            }
        }

        Repeater {
             id: repeater
             Column {
                Text {
                    text: "Name: " + modelData.name
                }
                Text {
                    text: "Phone number: " + modelData.phoneNumber
                }
                Button {
                    text: "Remove"
                    onClicked: {
                         collectionsModel.removeContact(index)
                         repeater.model = Net.toListModel(collectionsModel.contacts)
                    }
                }
             }
         }
        
        Text {
            id: message
        }
        
        CollectionsModel {
            id: collectionsModel
            Component.onCompleted: {
                repeater.model = Net.toListModel(collectionsModel.contacts)
            }
        }
    }
}
