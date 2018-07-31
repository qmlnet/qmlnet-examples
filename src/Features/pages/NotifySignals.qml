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
            text: "Properties can have associated signals that let Qml know when a specific property has changed."
        }

        Button {
            text: 'Change bound property from .NET'
            onClicked: {
                model.changeBindableProperty()
            }
        }
        
        Text {
            text: model.bindableProperty
        }
        
        NotifySignalsModel {
            id: model
        }
    }
}
