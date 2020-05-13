//
//  Subject.swift
//  observer
//
//  Created by Burak Çokyıldırım on 13.05.2020.
//  Copyright © 2020 burak. All rights reserved.
//

import Foundation

protocol Subject: class {

    func register(observer: Observer)
    func unregister(observer: Observer)
    func notify()
}
