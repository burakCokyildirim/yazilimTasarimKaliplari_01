//
//  USBObserver.swift
//  observer
//
//  Created by Burak Çokyıldırım on 13.05.2020.
//  Copyright © 2020 burak. All rights reserved.
//

import Foundation

class USBObserver: Observer {
    
    init(subject: Subject) {
        subject.register(observer: self)
    }
    
    func update(usbA: Bool, usbB: Bool, usbC: Bool) {
        print("usbA: \(usbA), usbB: \(usbB), usbC: \(usbC),")
    }
}
