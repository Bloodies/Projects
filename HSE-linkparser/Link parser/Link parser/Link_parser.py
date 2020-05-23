import sys
from PyQt5.QtWidgets import QWidget, QApplication
from PyQt5.QtGui import QPainter, QColor
from PyQt5.QtCore import *



class MyWidget(QWidget):
    def __init__(self):
        super().__init__()
        self.begin = QPoint()
        self.end = QPoint()

        flags = self.windowFlags() | Qt.FramelessWindowHint | Qt.WindowStaysOnTopHint
        self.setWindowFlags(flags)

        self.showFullScreen()

    def keyReleaseEvent(self, event):
        # Закрытие на кнопку Escape
        if event.key() == Qt.Key_Escape:
            self.close()

        super().keyReleaseEvent(event)

    def paintEvent(self, event):
        qp = QPainter(self)

        # Рисуем свой задний фон
        qp.save()
        qp.setBrush(Qt.white)
        qp.setPen(Qt.NoPen)
        qp.drawRect(self.rect())
        qp.restore()

        col = QColor(0, 0, 0)
        col.setNamedColor('red')
        qp.setPen(col)
        qp.drawRect(QRect(self.begin, self.end))

    def mousePressEvent(self, event):
        self.begin = event.pos()
        self.end = event.pos()
        self.update()

        super().mousePressEvent(event)

    def mouseMoveEvent(self, event):
        self.end = event.pos()
        self.update()

        super().mouseMoveEvent(event)

    def mouseReleaseEvent(self, event):
        self.end = event.pos()
        self.update()

        super().mouseReleaseEvent(event)


if __name__ == '__main__':
    app = QApplication(sys.argv)
    window = MyWidget()
    sys.exit(app.exec_())